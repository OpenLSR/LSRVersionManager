using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace LSRVersionManager
{
    [Flags]
    public enum GameArgs
    {
        None = 0,
        NoIntroVideo = 1 << 0,
        AllAI = 1 << 1,
        CDIn = 1 << 2,
        DebugInfo = 1 << 3,
        Files = 1 << 4,
        Freeform = 1 << 5,
        IGTest = 1 << 6,
        Load_Text = 1 << 7,
        NoRes = 1 << 8,
        Res_Files = 1 << 9,
        Windowed = 1 << 10,
        XAFToXBF = 1 << 11,
    }

    public partial class MainForm : Form
    {
        private RegistryManager regman;

        private readonly string configFile = "version_list.cfg";

        private string customArgs;

        private Version version;

        private List<Version> versionList = new List<Version>();

        public MainForm()
        {
            InitializeComponent();
        }

        public void LoadConfig()
        {
            if (!File.Exists(configFile)) return;
            versionList.Clear();
            var lines = File.ReadAllLines(configFile);
            foreach (var line in lines)
            {
                var tmp = line.Split(new char[]{'|'},2);
                if (Directory.Exists(tmp[0]))
                {
                    var ver = new Version(tmp[0]);
                    try { ver.args = (GameArgs)int.Parse(tmp[1]); }
                    catch { /* ok */ }
                    
                    versionList.Add(ver);
                }
            }
            RefreshVersions();
        }

        public void SaveConfig()
        {
            using (var file = new StreamWriter(configFile, false))
            foreach (var ver in versionList)
            {
                file.WriteLine($"{ver.path}|{(int)ver.args}");
            }
        }

        private void RefreshVersions()
        {
            versionsListView.Items.Clear();
            foreach (var item in versionList)
            {
                var lvi = new ListViewItem(item.cleanName, "LegoLogo");
                lvi.ToolTipText = Path.Combine(item.path, item.exeName);
                versionsListView.Items.Add(lvi);
                if (version!=null && item.path == version.path) lvi.Selected = lvi.Focused = true;
            }
            versionsListView.Select();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            notifyMenuVersion.Text = $"Version {this.ProductVersion}";
            this.Text += $" v{this.ProductVersion}";
            versionsListView.Items.Clear();
            LoadConfig();
            regman = new RegistryManager();
            ChangeVersion((string)regman.ReadKey("Path"));
        }

        private void RefreshArgs(EnumEditor editor, GameArgs args, GameArgs blacklistArgs = GameArgs.None)
        {
            editor.ClearDisabledItems();
            foreach (GameArgs r in Enum.GetValues(typeof(GameArgs)))
            {
                if ((blacklistArgs & r) != 0) editor.Disable(r.ToString());
            }
            editor.Value = args;
        }

        private void ChangeVersion(Version version)
        {
            launchBtn.Enabled = false;
            if (version.path == null) return;

            foreach (var item in versionList)
            {
                if (item.path == version.path)
                {
                    version = item;
                }
            }
            this.version = version;

            regman.WriteKey("Path", version.path);

            Console.WriteLine(version.cleanName);
            gameVersionLabel.Text = $"Version: {version.number}";
            gameModifiedLabel.Text = $"Modified: {version.dateModified}";
            

            RefreshArgs(launchArgsEditor, version.args, ~version.whitelistArgs);
            bool hasVersion = false;
            foreach (var item in versionList)
            {
                if (item.path == version.path) hasVersion = true;
            }
            if (!hasVersion) versionList.Add(version);
            RefreshVersions();
            launchBtn.Enabled = true;
        }

        private void ChangeVersion(string path)
        {
            if (path == null) return;
            version = new Version(path);
            ChangeVersion(version);
        }

        private string GetGameArgs()
        {
            return GetGameArgs(version.args); // TODO: Implement GUI controls for this.
        }

        private string GetGameArgs(GameArgs args)
        {
            List<string> result = new List<string>();
            foreach (GameArgs r in Enum.GetValues(typeof(GameArgs)))
            {
                if ((args & r) != 0) result.Add($"/{r.ToString().ToUpper()}");
            }
            return string.Join(" ",result.ToArray());
        }

        private void LaunchGame()
        {
            SaveConfig();
            if (version.exeName == null || version.exeName == string.Empty) MessageBox.Show("No exe registered! report bug!","Error");
            var startInfo = new ProcessStartInfo();
            startInfo.FileName = Path.Combine(version.path,version.exeName);
            startInfo.Arguments = string.Format("/FROMLAUNCHER {1} {0}", customArgs, GetGameArgs());
            startInfo.WorkingDirectory = version.path;
            Process proc = Process.Start(startInfo);
            if(keepLauncherCheck.Checked)
            {
                this.WindowState = FormWindowState.Minimized;
                notifyIcon.Visible = true;
                proc.WaitForExit();
                notifyIcon.Visible = false;
                this.WindowState = FormWindowState.Normal;
                if (proc.ExitCode != 0) MessageBox.Show($"LSR terminated with error code 0x{proc.ExitCode:X2}", "LSR Error");
            } 
            else
            {
                Environment.Exit(0);
            }
            
        }

        private void launchBtn_Click(object sender, EventArgs e)
        {
            LaunchGame();
        }

        private void customArgsBox_TextChanged(object sender, EventArgs e)
        {
            customArgs = customArgsBox.Text;
        }

        private void enumEditor1_SelectedIndexChanged(object sender, EventArgs e)
        {
            version.args = (GameArgs)launchArgsEditor.Value;
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            Console.WriteLine(versionsListView.FocusedItem.Index);
            ChangeVersion(versionList[versionsListView.FocusedItem.Index]);
        }

        private void AddVersion()
        {
            var dialog = new FolderBrowserDialog();
            dialog.SelectedPath = Environment.CurrentDirectory;
            dialog.Description = "Browse to the root folder of your LSR install.";
            if (dialog.ShowDialog() != DialogResult.OK) return;
            versionList.Add(new Version(dialog.SelectedPath));
            RefreshVersions();
        }

        private void RemoveVersion()
        {
            var msg = MessageBox.Show($"Are you sure you want to remove this version?\n{version.cleanName}","Remove Confirmation",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(msg == DialogResult.Yes)
            {
                versionList.Remove(version);
                launchBtn.Enabled = false;
                RefreshVersions();
            }
        }

        private void versionAddBtn_Click(object sender, EventArgs e)
        {
            AddVersion();
        }

        private void versionDelBtn_Click(object sender, EventArgs e)
        {
            RemoveVersion();
        }

        private void versionsMenuItemAdd_Click(object sender, EventArgs e)
        {
            AddVersion();
        }

        private void versionsMenuItemDel_Click(object sender, EventArgs e)
        {
            RemoveVersion();
        }

        private void notifyMenuExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
    }
}

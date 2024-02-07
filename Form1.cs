using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Configuration;
using System.Drawing;

namespace vinfo
{
    public partial class mainForm : Form
    {
        double totalSYSMemory;

        // Performance Counters for monitoring CPU, RAM, and system uptime
        PerformanceCounter perfCPU = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        PerformanceCounter perfRAM = new PerformanceCounter("Memory", "Available MBytes");
        PerformanceCounter perfSYS = new PerformanceCounter("System", "System Up Time");
        PerformanceCounter perfDISK = new PerformanceCounter("PhysicalDisk", "% Disk Time","_Total");


        [DllImport("shell32.dll", CharSet = CharSet.Unicode)]
        static extern int SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, RecycleFlags dwFlags);

        [Flags]
        enum RecycleFlags : uint
        {
            SHERB_NOCONFIRMATION = 0x00000001,
            SHERB_NOPROGRESSUI = 0x00000001,
            SHERB_NOSOUND = 0x00000004
        }


        public mainForm()
        {
            InitializeComponent();
            InitializeTheme("theme");
        }

        private void InitializeTheme(string themeName)
        {
            try
            {
                var theme = ConfigurationManager.AppSettings[themeName];

                if(theme == "Light")
                {
                    /* Background form */
                    this.BackColor = Color.FromArgb(255, 255, 255);

                    /* Buttons */
                    btn_cleanup_storage.ForeColor = Color.FromArgb(82, 147, 101);
                    btn_toggle_theme.ForeColor = Color.FromArgb(46, 52, 56);

                    /* List */
                    list_storage.BackColor = Color.FromArgb(255,255,255);
                    list_storage.ForeColor = Color.FromArgb(46, 52, 56);

                    /* Progress */
                    progress_bar_cpu_usage.OuterColor = Color.FromArgb(199, 204, 209);
                    progress_bar_cpu_usage.ProgressColor = Color.FromArgb(207, 115, 229);

                    progress_bar_available_usage.OuterColor = Color.FromArgb(199, 204, 209);
                    progress_bar_available_usage.ProgressColor = Color.FromArgb(72, 208, 166);

                    progress_bar_disk_usage.OuterColor = Color.FromArgb(199, 204, 209);
                    progress_bar_disk_usage.ProgressColor = Color.FromArgb(240, 130, 129);

                  
                    /* Title PC Name */
                    lbl_pc_name.ForeColor = Color.FromArgb(0, 0, 0);

                    /* Titles */
                    lbl_title_performance.ForeColor = Color.FromArgb(46, 52, 56);
                    lbl_title_hardware.ForeColor = Color.FromArgb(46, 52, 56);
                    lbl_title_storage.ForeColor = Color.FromArgb(46, 52, 56);
              
                    /* Subtitles */
                    lbl_subtitle_performance.ForeColor = Color.FromArgb(92, 104, 112);
                    lbl_subtitle_hardware.ForeColor = Color.FromArgb(92, 104, 112);
                    lbl_subtitle_storage.ForeColor = Color.FromArgb(92, 104, 112);

                    /* Items */
                    lbl_item_uptime_system.ForeColor = Color.FromArgb(69, 78, 84);
                    lbl_cpu_usage.ForeColor = Color.FromArgb(69, 78, 84);
                    lbl_available_memory.ForeColor = Color.FromArgb(69, 78, 84);
                    lbl_disk_usage.ForeColor = Color.FromArgb(69, 78, 84);
                    lbl_item_physical_processors.ForeColor = Color.FromArgb(69, 78, 84);
                    lbl_item_logical_processors.ForeColor = Color.FromArgb(69, 78, 84);
                    lbl_item_memory.ForeColor = Color.FromArgb(69, 78, 84);

                    /* Value Items */
                    lbl_up_time_system.ForeColor = Color.FromArgb(46, 52, 56);
                    lbl_physical_processors.ForeColor = Color.FromArgb(46, 52, 56);
                    lbl_logical_processors.ForeColor = Color.FromArgb(46, 52, 56);
                    lbl_total_memory.ForeColor = Color.FromArgb(46, 52, 56);
                    progress_bar_cpu_usage.ForeColor = Color.FromArgb(46, 52, 56);
                    progress_bar_available_usage.ForeColor = Color.FromArgb(46, 52, 56);
                    progress_bar_disk_usage.ForeColor = Color.FromArgb(46, 52, 56);
                 
                    btn_toggle_theme.Text = "Dark Mode";
                    ConfigurationManager.AppSettings[themeName] = "Dark";
                }
                else
                {
                    /* Background form */
                    this.BackColor = Color.FromArgb(0,0,0);

                    /* Buttons */
                    btn_cleanup_storage.ForeColor = Color.FromArgb(255, 255, 255);
                    btn_toggle_theme.ForeColor = Color.FromArgb(255, 255, 255);

                    /* List */
                    list_storage.BackColor = Color.FromArgb(0,0,0);
                    list_storage.ForeColor = Color.FromArgb(255,255,255);


                    /* Progress */
                    progress_bar_cpu_usage.OuterColor = Color.FromArgb(52, 57, 62);
                    progress_bar_cpu_usage.ProgressColor = Color.FromArgb(149, 55, 171);

                    progress_bar_available_usage.OuterColor = Color.FromArgb(52, 57, 62);
                    progress_bar_available_usage.ProgressColor = Color.FromArgb(33, 140, 102);

                    progress_bar_disk_usage.OuterColor = Color.FromArgb(52, 57, 62);
                    progress_bar_disk_usage.ProgressColor = Color.FromArgb(207, 48, 55);


                    /* Title PC Name */
                    lbl_pc_name.ForeColor = Color.FromArgb(255, 255, 255);

                    /* Titles */
                    lbl_title_performance.ForeColor = Color.FromArgb(255,255,255);
                    lbl_title_hardware.ForeColor = Color.FromArgb(255, 255, 255);
                    lbl_title_storage.ForeColor = Color.FromArgb(255, 255, 255);


                    /* Subtitles */
                    lbl_subtitle_performance.ForeColor = Color.FromArgb(128,128,128);
                    lbl_subtitle_hardware.ForeColor = Color.FromArgb(128, 128, 128);
                    lbl_subtitle_storage.ForeColor = Color.FromArgb(128, 128, 128);

                    /* Items */
                    lbl_item_uptime_system.ForeColor = Color.FromArgb(169, 169, 169);
                    lbl_cpu_usage.ForeColor = Color.FromArgb(169, 169, 169);
                    lbl_available_memory.ForeColor = Color.FromArgb(169, 169, 169);
                    lbl_disk_usage.ForeColor = Color.FromArgb(169, 169, 169);
                    lbl_item_physical_processors.ForeColor = Color.FromArgb(169, 169, 169);
                    lbl_item_logical_processors.ForeColor = Color.FromArgb(169, 169, 169);
                    lbl_item_memory.ForeColor = Color.FromArgb(169, 169, 169);

                    /* Value Items */
                    lbl_up_time_system.ForeColor = Color.FromArgb(255, 255, 255);
                    lbl_physical_processors.ForeColor = Color.FromArgb(255, 255, 255);
                    lbl_logical_processors.ForeColor = Color.FromArgb(255, 255, 255);
                    lbl_total_memory.ForeColor = Color.FromArgb(255, 255, 255);
                    progress_bar_cpu_usage.ForeColor = Color.FromArgb(255, 255, 255);
                    progress_bar_available_usage.ForeColor = Color.FromArgb(255, 255, 255);
                    progress_bar_disk_usage.ForeColor = Color.FromArgb(255, 255, 255);

                    btn_toggle_theme.Text = "Light Mode";
                    ConfigurationManager.AppSettings[themeName] = "Light";
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            // Enable timers for updating CPU and memory usage
            timer_update_memory_usage.Enabled = true;
            timer_update_cpu_usage.Enabled = true;
            timer_update_disk_usage.Enabled = true;
            timer_update_uptime_system.Enabled = true;  

            // Retrieve and display system information
            GetSystemInfo();
            GetStorageInfo();
        }

     
        private void GetSystemInfo()
        {
            try
            {
                // WMI query to retrieve system information
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
                ManagementObjectCollection collection = searcher.Get();

                foreach (ManagementObject info in collection)
                {
                    // Total physical processors
                    int physicalProcessors = Convert.ToInt32(info["NumberOfProcessors"]);
                    // Total logical processors
                    int logicalProcessors = Convert.ToInt32(info["NumberOfLogicalProcessors"]);
                    // Total RAM in bytes
                    ulong totalMemoryBytes = Convert.ToUInt64(info["TotalPhysicalMemory"]);

                    //Computer name
                    lbl_pc_name.Text = Convert.ToString(info["Name"]);
                 
                    // Total Memory in mb
                    totalSYSMemory = totalMemoryBytes / (1024.0 * 1024.0);

                    // Convert bytes to gigabytes for easier reading
                    double totalMemoryGB = totalMemoryBytes / (1024.0 * 1024.0 * 1024.0);

                    // Display information
                    lbl_physical_processors.Text = physicalProcessors.ToString();
                    lbl_logical_processors.Text = logicalProcessors.ToString();
                    lbl_total_memory.Text = $"{totalMemoryGB:F2} GB";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error obtaining system information: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer_update_memory_usage_Tick(object sender, EventArgs e)
        {
            // Calculate and display available memory usage
            progress_bar_available_usage.Text = ((int)((perfRAM.NextValue() / totalSYSMemory) * 100)).ToString() + "%";

      
            // Set progress bar properties for memory usage
            progress_bar_available_usage.Minimum = 0;
            progress_bar_available_usage.Maximum = (int)totalSYSMemory;
            progress_bar_available_usage.Value = (int)perfRAM.NextValue();
        }

        private void timer_update_cpu_usage_Tick(object sender, EventArgs e)
        {
            // Calculate and display CPU usage
            float cpuUsage = perfCPU.NextValue();
            progress_bar_cpu_usage.Text = $"{(int)cpuUsage}%";

            // Set progress bar properties for CPU usage
            progress_bar_cpu_usage.Minimum = 0;
            progress_bar_cpu_usage.Maximum = 100;
            progress_bar_cpu_usage.Value = (int)cpuUsage;
        }

        private void GetStorageInfo()
        {
            try
            {

                list_storage.Items.Clear();
                // WMI query to retrieve storage information
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_LogicalDisk");
                ManagementObjectCollection collection = searcher.Get();

                foreach (ManagementObject info in collection)
                {
                    // Device ID (Drive letter)
                    string deviceID = info["DeviceID"].ToString();
                    // Volume Name
                    string volumeName = info["VolumeName"] != null ? info["VolumeName"].ToString() : "N/A";
                    // File System (NTFS, FAT32, etc.)
                    string fileSystem = info["FileSystem"].ToString();
                    // Total size in bytes
                    ulong totalSizeBytes = Convert.ToUInt64(info["Size"]);
                    // Free space in bytes
                    ulong freeSpaceBytes = Convert.ToUInt64(info["FreeSpace"]);

                    // Convert bytes to gigabytes for easier reading
                    double totalSizeGB = totalSizeBytes / (1024.0 * 1024.0 * 1024.0);
                    double freeSpaceGB = freeSpaceBytes / (1024.0 * 1024.0 * 1024.0);
                    double usedSpaceGB = totalSizeGB - freeSpaceGB;


                    list_storage.Items.Add($"{deviceID} - Used Space: {usedSpaceGB:F2} GB - Free Space: {freeSpaceGB:F2} GB");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error obtaining storage information: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer_update_disk_usage_Tick(object sender, EventArgs e)
        {
            // Calculate and display disk usage
            float diskUsage = perfDISK.NextValue();
            progress_bar_disk_usage.Text = $"{(int)diskUsage}%";

            // Set progress bar properties for disk usage
            progress_bar_disk_usage.Minimum = 0;
            progress_bar_disk_usage.Maximum = 100;
            progress_bar_disk_usage.Value = (int)diskUsage < 100 ? (int)diskUsage : 100;
        }

        private void timer_update_uptime_system_Tick(object sender, EventArgs e)
        {
            // Display system uptime in minutes
            lbl_up_time_system.Text = ((int)perfSYS.NextValue() / 60).ToString() + " minutes";
        }

        private void btn_cleanup_storage_Click(object sender, EventArgs e)
        {
            CleanTempDirectory();
            EmptyRecycleBin();
            MessageBox.Show("Cleanup completed successfully!");
        }

        static void CleanTempDirectory()
        {
            string tempPath = Path.GetTempPath();
            DirectoryInfo tempDir = new DirectoryInfo(tempPath);

            foreach (FileInfo file in tempDir.GetFiles())
            {
                try
                {
                    file.Delete();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error deleting file {file.FullName}: {ex.Message}");
                }
            }
        }

        static void EmptyRecycleBin()
        {
            try
            {
                int result = SHEmptyRecycleBin(IntPtr.Zero, null, RecycleFlags.SHERB_NOCONFIRMATION);

                if (result == 0)
                {
                    Console.WriteLine("Recycle Bin emptied successfully!");
                }
                else
                {
                    Console.WriteLine($"Error emptying Recycle Bin. Error code: {result}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error emptying Recycle Bin: {ex.Message}");
            }
        }

        private void btn_toggle_theme_Click(object sender, EventArgs e)
        {
            InitializeTheme("theme");
        }

      
    
    }
}

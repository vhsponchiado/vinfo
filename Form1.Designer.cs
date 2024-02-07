namespace vinfo
{
    partial class mainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.lbl_title_performance = new System.Windows.Forms.Label();
            this.lbl_subtitle_performance = new System.Windows.Forms.Label();
            this.lbl_cpu_usage = new System.Windows.Forms.Label();
            this.timer_update_memory_usage = new System.Windows.Forms.Timer(this.components);
            this.lbl_available_memory = new System.Windows.Forms.Label();
            this.lbl_item_uptime_system = new System.Windows.Forms.Label();
            this.lbl_up_time_system = new System.Windows.Forms.Label();
            this.lbl_subtitle_hardware = new System.Windows.Forms.Label();
            this.lbl_logical_processors = new System.Windows.Forms.Label();
            this.lbl_item_logical_processors = new System.Windows.Forms.Label();
            this.lbl_physical_processors = new System.Windows.Forms.Label();
            this.lbl_item_physical_processors = new System.Windows.Forms.Label();
            this.lbl_total_memory = new System.Windows.Forms.Label();
            this.lbl_item_memory = new System.Windows.Forms.Label();
            this.progress_bar_available_usage = new CircularProgressBar.CircularProgressBar();
            this.progress_bar_cpu_usage = new CircularProgressBar.CircularProgressBar();
            this.timer_update_cpu_usage = new System.Windows.Forms.Timer(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_title_hardware = new System.Windows.Forms.Label();
            this.lbl_title_storage = new System.Windows.Forms.Label();
            this.lbl_subtitle_storage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.list_storage = new System.Windows.Forms.ListBox();
            this.lbl_pc_name = new System.Windows.Forms.Label();
            this.lbl_cpu_cors = new System.Windows.Forms.Label();
            this.progress_bar_disk_usage = new CircularProgressBar.CircularProgressBar();
            this.lbl_disk_usage = new System.Windows.Forms.Label();
            this.timer_update_disk_usage = new System.Windows.Forms.Timer(this.components);
            this.timer_update_uptime_system = new System.Windows.Forms.Timer(this.components);
            this.btn_toggle_theme = new Guna.UI2.WinForms.Guna2Button();
            this.tooltip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.btn_cleanup_storage = new Guna.UI2.WinForms.Guna2Button();
            this.timer_update_video_controller = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title_performance
            // 
            this.lbl_title_performance.AutoSize = true;
            this.lbl_title_performance.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title_performance.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title_performance.ForeColor = System.Drawing.Color.White;
            this.lbl_title_performance.Location = new System.Drawing.Point(20, 85);
            this.lbl_title_performance.Name = "lbl_title_performance";
            this.lbl_title_performance.Size = new System.Drawing.Size(134, 30);
            this.lbl_title_performance.TabIndex = 0;
            this.lbl_title_performance.Text = "Performance";
            // 
            // lbl_subtitle_performance
            // 
            this.lbl_subtitle_performance.AutoSize = true;
            this.lbl_subtitle_performance.BackColor = System.Drawing.Color.Transparent;
            this.lbl_subtitle_performance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtitle_performance.ForeColor = System.Drawing.Color.Gray;
            this.lbl_subtitle_performance.Location = new System.Drawing.Point(22, 115);
            this.lbl_subtitle_performance.Name = "lbl_subtitle_performance";
            this.lbl_subtitle_performance.Size = new System.Drawing.Size(263, 17);
            this.lbl_subtitle_performance.TabIndex = 1;
            this.lbl_subtitle_performance.Text = "See your computer´s current performance";
            // 
            // lbl_cpu_usage
            // 
            this.lbl_cpu_usage.AutoSize = true;
            this.lbl_cpu_usage.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpu_usage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpu_usage.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_cpu_usage.Location = new System.Drawing.Point(50, 290);
            this.lbl_cpu_usage.Name = "lbl_cpu_usage";
            this.lbl_cpu_usage.Size = new System.Drawing.Size(73, 17);
            this.lbl_cpu_usage.TabIndex = 2;
            this.lbl_cpu_usage.Text = "CPU usage";
            // 
            // timer_update_memory_usage
            // 
            this.timer_update_memory_usage.Interval = 300;
            this.timer_update_memory_usage.Tick += new System.EventHandler(this.timer_update_memory_usage_Tick);
            // 
            // lbl_available_memory
            // 
            this.lbl_available_memory.AutoSize = true;
            this.lbl_available_memory.BackColor = System.Drawing.Color.Transparent;
            this.lbl_available_memory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_available_memory.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_available_memory.Location = new System.Drawing.Point(243, 290);
            this.lbl_available_memory.Name = "lbl_available_memory";
            this.lbl_available_memory.Size = new System.Drawing.Size(118, 17);
            this.lbl_available_memory.TabIndex = 4;
            this.lbl_available_memory.Text = "Available memory";
            // 
            // lbl_item_uptime_system
            // 
            this.lbl_item_uptime_system.AutoSize = true;
            this.lbl_item_uptime_system.BackColor = System.Drawing.Color.Transparent;
            this.lbl_item_uptime_system.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item_uptime_system.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_item_uptime_system.Location = new System.Drawing.Point(23, 52);
            this.lbl_item_uptime_system.Name = "lbl_item_uptime_system";
            this.lbl_item_uptime_system.Size = new System.Drawing.Size(87, 13);
            this.lbl_item_uptime_system.TabIndex = 6;
            this.lbl_item_uptime_system.Text = "Up time system";
            // 
            // lbl_up_time_system
            // 
            this.lbl_up_time_system.AutoSize = true;
            this.lbl_up_time_system.BackColor = System.Drawing.Color.Transparent;
            this.lbl_up_time_system.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_up_time_system.ForeColor = System.Drawing.Color.White;
            this.lbl_up_time_system.Location = new System.Drawing.Point(113, 52);
            this.lbl_up_time_system.Name = "lbl_up_time_system";
            this.lbl_up_time_system.Size = new System.Drawing.Size(56, 13);
            this.lbl_up_time_system.TabIndex = 7;
            this.lbl_up_time_system.Text = "0 minutes";
            // 
            // lbl_subtitle_hardware
            // 
            this.lbl_subtitle_hardware.AutoSize = true;
            this.lbl_subtitle_hardware.BackColor = System.Drawing.Color.Transparent;
            this.lbl_subtitle_hardware.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtitle_hardware.ForeColor = System.Drawing.Color.Gray;
            this.lbl_subtitle_hardware.Location = new System.Drawing.Point(22, 375);
            this.lbl_subtitle_hardware.Name = "lbl_subtitle_hardware";
            this.lbl_subtitle_hardware.Size = new System.Drawing.Size(150, 17);
            this.lbl_subtitle_hardware.TabIndex = 9;
            this.lbl_subtitle_hardware.Text = "Processor and memory";
            // 
            // lbl_logical_processors
            // 
            this.lbl_logical_processors.AutoSize = true;
            this.lbl_logical_processors.BackColor = System.Drawing.Color.Transparent;
            this.lbl_logical_processors.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logical_processors.ForeColor = System.Drawing.Color.White;
            this.lbl_logical_processors.Location = new System.Drawing.Point(146, 440);
            this.lbl_logical_processors.Name = "lbl_logical_processors";
            this.lbl_logical_processors.Size = new System.Drawing.Size(15, 17);
            this.lbl_logical_processors.TabIndex = 13;
            this.lbl_logical_processors.Text = "0";
            // 
            // lbl_item_logical_processors
            // 
            this.lbl_item_logical_processors.AutoSize = true;
            this.lbl_item_logical_processors.BackColor = System.Drawing.Color.Transparent;
            this.lbl_item_logical_processors.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item_logical_processors.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_item_logical_processors.Location = new System.Drawing.Point(22, 440);
            this.lbl_item_logical_processors.Name = "lbl_item_logical_processors";
            this.lbl_item_logical_processors.Size = new System.Drawing.Size(118, 17);
            this.lbl_item_logical_processors.TabIndex = 12;
            this.lbl_item_logical_processors.Text = "Logical processors";
            // 
            // lbl_physical_processors
            // 
            this.lbl_physical_processors.AutoSize = true;
            this.lbl_physical_processors.BackColor = System.Drawing.Color.Transparent;
            this.lbl_physical_processors.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_physical_processors.ForeColor = System.Drawing.Color.White;
            this.lbl_physical_processors.Location = new System.Drawing.Point(153, 419);
            this.lbl_physical_processors.Name = "lbl_physical_processors";
            this.lbl_physical_processors.Size = new System.Drawing.Size(15, 17);
            this.lbl_physical_processors.TabIndex = 11;
            this.lbl_physical_processors.Text = "0";
            // 
            // lbl_item_physical_processors
            // 
            this.lbl_item_physical_processors.AutoSize = true;
            this.lbl_item_physical_processors.BackColor = System.Drawing.Color.Transparent;
            this.lbl_item_physical_processors.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item_physical_processors.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_item_physical_processors.Location = new System.Drawing.Point(22, 419);
            this.lbl_item_physical_processors.Name = "lbl_item_physical_processors";
            this.lbl_item_physical_processors.Size = new System.Drawing.Size(125, 17);
            this.lbl_item_physical_processors.TabIndex = 10;
            this.lbl_item_physical_processors.Text = "Physical processors";
            // 
            // lbl_total_memory
            // 
            this.lbl_total_memory.AutoSize = true;
            this.lbl_total_memory.BackColor = System.Drawing.Color.Transparent;
            this.lbl_total_memory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_memory.ForeColor = System.Drawing.Color.White;
            this.lbl_total_memory.Location = new System.Drawing.Point(88, 460);
            this.lbl_total_memory.Name = "lbl_total_memory";
            this.lbl_total_memory.Size = new System.Drawing.Size(15, 17);
            this.lbl_total_memory.TabIndex = 15;
            this.lbl_total_memory.Text = "0";
            // 
            // lbl_item_memory
            // 
            this.lbl_item_memory.AutoSize = true;
            this.lbl_item_memory.BackColor = System.Drawing.Color.Transparent;
            this.lbl_item_memory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item_memory.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_item_memory.Location = new System.Drawing.Point(22, 460);
            this.lbl_item_memory.Name = "lbl_item_memory";
            this.lbl_item_memory.Size = new System.Drawing.Size(60, 17);
            this.lbl_item_memory.TabIndex = 14;
            this.lbl_item_memory.Text = "Memory";
            // 
            // progress_bar_available_usage
            // 
            this.progress_bar_available_usage.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.progress_bar_available_usage.AnimationSpeed = 500;
            this.progress_bar_available_usage.BackColor = System.Drawing.Color.Transparent;
            this.progress_bar_available_usage.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progress_bar_available_usage.ForeColor = System.Drawing.Color.White;
            this.progress_bar_available_usage.InnerColor = System.Drawing.Color.Transparent;
            this.progress_bar_available_usage.InnerMargin = 2;
            this.progress_bar_available_usage.InnerWidth = -1;
            this.progress_bar_available_usage.Location = new System.Drawing.Point(241, 158);
            this.progress_bar_available_usage.MarqueeAnimationSpeed = 2000;
            this.progress_bar_available_usage.Name = "progress_bar_available_usage";
            this.progress_bar_available_usage.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.progress_bar_available_usage.OuterMargin = -25;
            this.progress_bar_available_usage.OuterWidth = 26;
            this.progress_bar_available_usage.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(135)))), ((int)(((byte)(97)))));
            this.progress_bar_available_usage.ProgressWidth = 12;
            this.progress_bar_available_usage.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.progress_bar_available_usage.Size = new System.Drawing.Size(120, 120);
            this.progress_bar_available_usage.StartAngle = 0;
            this.progress_bar_available_usage.SubscriptColor = System.Drawing.Color.Transparent;
            this.progress_bar_available_usage.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.progress_bar_available_usage.SubscriptText = "";
            this.progress_bar_available_usage.SuperscriptColor = System.Drawing.Color.Transparent;
            this.progress_bar_available_usage.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progress_bar_available_usage.SuperscriptText = "";
            this.progress_bar_available_usage.TabIndex = 18;
            this.progress_bar_available_usage.TextMargin = new System.Windows.Forms.Padding(0);
            this.progress_bar_available_usage.Value = 68;
            // 
            // progress_bar_cpu_usage
            // 
            this.progress_bar_cpu_usage.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.progress_bar_cpu_usage.AnimationSpeed = 500;
            this.progress_bar_cpu_usage.BackColor = System.Drawing.Color.Transparent;
            this.progress_bar_cpu_usage.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progress_bar_cpu_usage.ForeColor = System.Drawing.Color.White;
            this.progress_bar_cpu_usage.InnerColor = System.Drawing.Color.Transparent;
            this.progress_bar_cpu_usage.InnerMargin = 2;
            this.progress_bar_cpu_usage.InnerWidth = -1;
            this.progress_bar_cpu_usage.Location = new System.Drawing.Point(25, 158);
            this.progress_bar_cpu_usage.MarqueeAnimationSpeed = 2000;
            this.progress_bar_cpu_usage.Name = "progress_bar_cpu_usage";
            this.progress_bar_cpu_usage.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.progress_bar_cpu_usage.OuterMargin = -25;
            this.progress_bar_cpu_usage.OuterWidth = 26;
            this.progress_bar_cpu_usage.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(58)))), ((int)(((byte)(173)))));
            this.progress_bar_cpu_usage.ProgressWidth = 12;
            this.progress_bar_cpu_usage.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.progress_bar_cpu_usage.Size = new System.Drawing.Size(120, 120);
            this.progress_bar_cpu_usage.StartAngle = 0;
            this.progress_bar_cpu_usage.SubscriptColor = System.Drawing.Color.Transparent;
            this.progress_bar_cpu_usage.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.progress_bar_cpu_usage.SubscriptText = "";
            this.progress_bar_cpu_usage.SuperscriptColor = System.Drawing.Color.Transparent;
            this.progress_bar_cpu_usage.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progress_bar_cpu_usage.SuperscriptText = "";
            this.progress_bar_cpu_usage.TabIndex = 19;
            this.progress_bar_cpu_usage.TextMargin = new System.Windows.Forms.Padding(0);
            this.progress_bar_cpu_usage.Value = 68;
            // 
            // timer_update_cpu_usage
            // 
            this.timer_update_cpu_usage.Interval = 300;
            this.timer_update_cpu_usage.Tick += new System.EventHandler(this.timer_update_cpu_usage_Tick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(344, 515);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(233, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "1.0.0 powered by Vinícius Sponchiado";
            // 
            // lbl_title_hardware
            // 
            this.lbl_title_hardware.AutoSize = true;
            this.lbl_title_hardware.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title_hardware.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title_hardware.ForeColor = System.Drawing.Color.White;
            this.lbl_title_hardware.Location = new System.Drawing.Point(20, 345);
            this.lbl_title_hardware.Name = "lbl_title_hardware";
            this.lbl_title_hardware.Size = new System.Drawing.Size(106, 30);
            this.lbl_title_hardware.TabIndex = 8;
            this.lbl_title_hardware.Text = "Hardware";
            // 
            // lbl_title_storage
            // 
            this.lbl_title_storage.AutoSize = true;
            this.lbl_title_storage.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title_storage.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title_storage.ForeColor = System.Drawing.Color.White;
            this.lbl_title_storage.Location = new System.Drawing.Point(210, 345);
            this.lbl_title_storage.Name = "lbl_title_storage";
            this.lbl_title_storage.Size = new System.Drawing.Size(87, 30);
            this.lbl_title_storage.TabIndex = 23;
            this.lbl_title_storage.Text = "Storage";
            // 
            // lbl_subtitle_storage
            // 
            this.lbl_subtitle_storage.AutoSize = true;
            this.lbl_subtitle_storage.BackColor = System.Drawing.Color.Transparent;
            this.lbl_subtitle_storage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtitle_storage.ForeColor = System.Drawing.Color.Gray;
            this.lbl_subtitle_storage.Location = new System.Drawing.Point(212, 378);
            this.lbl_subtitle_storage.Name = "lbl_subtitle_storage";
            this.lbl_subtitle_storage.Size = new System.Drawing.Size(211, 17);
            this.lbl_subtitle_storage.TabIndex = 24;
            this.lbl_subtitle_storage.Text = "Drives, used space and free space";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.list_storage);
            this.panel1.Location = new System.Drawing.Point(215, 419);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 82);
            this.panel1.TabIndex = 25;
            // 
            // list_storage
            // 
            this.list_storage.BackColor = System.Drawing.SystemColors.WindowText;
            this.list_storage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_storage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_storage.Enabled = false;
            this.list_storage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_storage.ForeColor = System.Drawing.Color.White;
            this.list_storage.FormattingEnabled = true;
            this.list_storage.ItemHeight = 17;
            this.list_storage.Location = new System.Drawing.Point(0, 0);
            this.list_storage.Name = "list_storage";
            this.list_storage.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.list_storage.Size = new System.Drawing.Size(362, 82);
            this.list_storage.TabIndex = 1;
            // 
            // lbl_pc_name
            // 
            this.lbl_pc_name.AutoSize = true;
            this.lbl_pc_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pc_name.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pc_name.ForeColor = System.Drawing.Color.White;
            this.lbl_pc_name.Location = new System.Drawing.Point(20, 20);
            this.lbl_pc_name.Name = "lbl_pc_name";
            this.lbl_pc_name.Size = new System.Drawing.Size(99, 30);
            this.lbl_pc_name.TabIndex = 9;
            this.lbl_pc_name.Text = "Name pc";
            // 
            // lbl_cpu_cors
            // 
            this.lbl_cpu_cors.AutoSize = true;
            this.lbl_cpu_cors.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpu_cors.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpu_cors.ForeColor = System.Drawing.Color.White;
            this.lbl_cpu_cors.Location = new System.Drawing.Point(59, 95);
            this.lbl_cpu_cors.Name = "lbl_cpu_cors";
            this.lbl_cpu_cors.Size = new System.Drawing.Size(0, 30);
            this.lbl_cpu_cors.TabIndex = 26;
            // 
            // progress_bar_disk_usage
            // 
            this.progress_bar_disk_usage.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.progress_bar_disk_usage.AnimationSpeed = 500;
            this.progress_bar_disk_usage.BackColor = System.Drawing.Color.Transparent;
            this.progress_bar_disk_usage.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progress_bar_disk_usage.ForeColor = System.Drawing.Color.White;
            this.progress_bar_disk_usage.InnerColor = System.Drawing.Color.Transparent;
            this.progress_bar_disk_usage.InnerMargin = 2;
            this.progress_bar_disk_usage.InnerWidth = -1;
            this.progress_bar_disk_usage.Location = new System.Drawing.Point(462, 158);
            this.progress_bar_disk_usage.MarqueeAnimationSpeed = 2000;
            this.progress_bar_disk_usage.Name = "progress_bar_disk_usage";
            this.progress_bar_disk_usage.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.progress_bar_disk_usage.OuterMargin = -25;
            this.progress_bar_disk_usage.OuterWidth = 26;
            this.progress_bar_disk_usage.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(86)))), ((int)(((byte)(34)))));
            this.progress_bar_disk_usage.ProgressWidth = 12;
            this.progress_bar_disk_usage.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.progress_bar_disk_usage.Size = new System.Drawing.Size(120, 120);
            this.progress_bar_disk_usage.StartAngle = 0;
            this.progress_bar_disk_usage.SubscriptColor = System.Drawing.Color.Transparent;
            this.progress_bar_disk_usage.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.progress_bar_disk_usage.SubscriptText = "";
            this.progress_bar_disk_usage.SuperscriptColor = System.Drawing.Color.Transparent;
            this.progress_bar_disk_usage.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progress_bar_disk_usage.SuperscriptText = "";
            this.progress_bar_disk_usage.TabIndex = 27;
            this.progress_bar_disk_usage.TextMargin = new System.Windows.Forms.Padding(0);
            this.progress_bar_disk_usage.Value = 68;
            // 
            // lbl_disk_usage
            // 
            this.lbl_disk_usage.AutoSize = true;
            this.lbl_disk_usage.BackColor = System.Drawing.Color.Transparent;
            this.lbl_disk_usage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_disk_usage.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_disk_usage.Location = new System.Drawing.Point(484, 290);
            this.lbl_disk_usage.Name = "lbl_disk_usage";
            this.lbl_disk_usage.Size = new System.Drawing.Size(73, 17);
            this.lbl_disk_usage.TabIndex = 28;
            this.lbl_disk_usage.Text = "Disk usage";
            // 
            // timer_update_disk_usage
            // 
            this.timer_update_disk_usage.Interval = 300;
            this.timer_update_disk_usage.Tick += new System.EventHandler(this.timer_update_disk_usage_Tick);
            // 
            // timer_update_uptime_system
            // 
            this.timer_update_uptime_system.Interval = 300;
            this.timer_update_uptime_system.Tick += new System.EventHandler(this.timer_update_uptime_system_Tick);
            // 
            // btn_toggle_theme
            // 
            this.btn_toggle_theme.Animated = true;
            this.btn_toggle_theme.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_toggle_theme.BorderRadius = 16;
            this.btn_toggle_theme.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.btn_toggle_theme.BorderThickness = 2;
            this.btn_toggle_theme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_toggle_theme.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_toggle_theme.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_toggle_theme.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_toggle_theme.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_toggle_theme.FillColor = System.Drawing.Color.Transparent;
            this.btn_toggle_theme.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_toggle_theme.ForeColor = System.Drawing.Color.White;
            this.btn_toggle_theme.ImageSize = new System.Drawing.Size(16, 16);
            this.btn_toggle_theme.Location = new System.Drawing.Point(482, 15);
            this.btn_toggle_theme.Name = "btn_toggle_theme";
            this.btn_toggle_theme.Size = new System.Drawing.Size(100, 50);
            this.btn_toggle_theme.TabIndex = 30;
            this.btn_toggle_theme.Text = "Theme";
            this.btn_toggle_theme.Click += new System.EventHandler(this.btn_toggle_theme_Click);
            // 
            // tooltip
            // 
            this.tooltip.AllowLinksHandling = true;
            this.tooltip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tooltip.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tooltip.ForeColor = System.Drawing.Color.White;
            this.tooltip.MaximumSize = new System.Drawing.Size(0, 0);
            this.tooltip.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.tooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tooltip.ToolTipTitle = "Info";
            // 
            // btn_cleanup_storage
            // 
            this.btn_cleanup_storage.Animated = true;
            this.btn_cleanup_storage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(157)))), ((int)(((byte)(71)))));
            this.btn_cleanup_storage.BorderRadius = 16;
            this.btn_cleanup_storage.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.btn_cleanup_storage.BorderThickness = 2;
            this.btn_cleanup_storage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cleanup_storage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cleanup_storage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_cleanup_storage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cleanup_storage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_cleanup_storage.FillColor = System.Drawing.Color.Transparent;
            this.btn_cleanup_storage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cleanup_storage.ForeColor = System.Drawing.Color.White;
            this.btn_cleanup_storage.Image = global::vinfo.Properties.Resources.broom;
            this.btn_cleanup_storage.ImageSize = new System.Drawing.Size(16, 16);
            this.btn_cleanup_storage.Location = new System.Drawing.Point(462, 345);
            this.btn_cleanup_storage.Name = "btn_cleanup_storage";
            this.btn_cleanup_storage.Size = new System.Drawing.Size(115, 50);
            this.btn_cleanup_storage.TabIndex = 29;
            this.btn_cleanup_storage.Text = "Clean up";
            this.tooltip.SetToolTip(this.btn_cleanup_storage, "Clean up temp files and empty recycle bin");
            this.btn_cleanup_storage.Click += new System.EventHandler(this.btn_cleanup_storage_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(604, 561);
            this.Controls.Add(this.btn_toggle_theme);
            this.Controls.Add(this.btn_cleanup_storage);
            this.Controls.Add(this.lbl_disk_usage);
            this.Controls.Add(this.progress_bar_disk_usage);
            this.Controls.Add(this.lbl_cpu_cors);
            this.Controls.Add(this.lbl_pc_name);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_subtitle_storage);
            this.Controls.Add(this.lbl_title_storage);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.progress_bar_cpu_usage);
            this.Controls.Add(this.progress_bar_available_usage);
            this.Controls.Add(this.lbl_total_memory);
            this.Controls.Add(this.lbl_item_memory);
            this.Controls.Add(this.lbl_logical_processors);
            this.Controls.Add(this.lbl_item_logical_processors);
            this.Controls.Add(this.lbl_physical_processors);
            this.Controls.Add(this.lbl_item_physical_processors);
            this.Controls.Add(this.lbl_subtitle_hardware);
            this.Controls.Add(this.lbl_title_hardware);
            this.Controls.Add(this.lbl_up_time_system);
            this.Controls.Add(this.lbl_item_uptime_system);
            this.Controls.Add(this.lbl_available_memory);
            this.Controls.Add(this.lbl_cpu_usage);
            this.Controls.Add(this.lbl_subtitle_performance);
            this.Controls.Add(this.lbl_title_performance);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(620, 600);
            this.MinimumSize = new System.Drawing.Size(620, 600);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VINfo";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title_performance;
        private System.Windows.Forms.Label lbl_subtitle_performance;
        private System.Windows.Forms.Label lbl_cpu_usage;
        private System.Windows.Forms.Timer timer_update_memory_usage;
        private System.Windows.Forms.Label lbl_available_memory;
        private System.Windows.Forms.Label lbl_item_uptime_system;
        private System.Windows.Forms.Label lbl_up_time_system;
        private System.Windows.Forms.Label lbl_subtitle_hardware;
        private System.Windows.Forms.Label lbl_logical_processors;
        private System.Windows.Forms.Label lbl_item_logical_processors;
        private System.Windows.Forms.Label lbl_physical_processors;
        private System.Windows.Forms.Label lbl_item_physical_processors;
        private System.Windows.Forms.Label lbl_total_memory;
        private System.Windows.Forms.Label lbl_item_memory;
        private CircularProgressBar.CircularProgressBar progress_bar_available_usage;
        private CircularProgressBar.CircularProgressBar progress_bar_cpu_usage;
        private System.Windows.Forms.Timer timer_update_cpu_usage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_title_hardware;
        private System.Windows.Forms.Label lbl_title_storage;
        private System.Windows.Forms.Label lbl_subtitle_storage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox list_storage;
        private System.Windows.Forms.Label lbl_pc_name;
        private System.Windows.Forms.Label lbl_cpu_cors;
        private CircularProgressBar.CircularProgressBar progress_bar_disk_usage;
        private System.Windows.Forms.Label lbl_disk_usage;
        private System.Windows.Forms.Timer timer_update_disk_usage;
        private Guna.UI2.WinForms.Guna2Button btn_cleanup_storage;
        private System.Windows.Forms.Timer timer_update_uptime_system;
        private Guna.UI2.WinForms.Guna2Button btn_toggle_theme;
        private Guna.UI2.WinForms.Guna2HtmlToolTip tooltip;
        private System.Windows.Forms.Timer timer_update_video_controller;
    }
}


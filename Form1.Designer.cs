namespace Бд
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьПреподавателяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ljToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьОтделениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьГруппуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокПредметовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ew3rfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.MistyRose;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(144, 46);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(865, 371);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ФИО";
            this.columnHeader1.Width = 376;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Предмет";
            this.columnHeader2.Width = 199;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(155, 48);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MistyRose;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьПреподавателяToolStripMenuItem,
            this.ljToolStripMenuItem,
            this.студентыToolStripMenuItem,
            this.добавитьОтделениеToolStripMenuItem,
            this.добавитьГруппуToolStripMenuItem,
            this.списокПредметовToolStripMenuItem,
            this.ew3rfToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1174, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // добавитьПреподавателяToolStripMenuItem
            // 
            this.добавитьПреподавателяToolStripMenuItem.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.добавитьПреподавателяToolStripMenuItem.Name = "добавитьПреподавателяToolStripMenuItem";
            this.добавитьПреподавателяToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.добавитьПреподавателяToolStripMenuItem.Text = "Добавить преподавателя";
            this.добавитьПреподавателяToolStripMenuItem.Click += new System.EventHandler(this.добавитьПреподавателяToolStripMenuItem_Click);
            // 
            // ljToolStripMenuItem
            // 
            this.ljToolStripMenuItem.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ljToolStripMenuItem.Name = "ljToolStripMenuItem";
            this.ljToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.ljToolStripMenuItem.Text = "Добавить предмет";
            this.ljToolStripMenuItem.Click += new System.EventHandler(this.ljToolStripMenuItem_Click);
            // 
            // студентыToolStripMenuItem
            // 
            this.студентыToolStripMenuItem.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.студентыToolStripMenuItem.Name = "студентыToolStripMenuItem";
            this.студентыToolStripMenuItem.Size = new System.Drawing.Size(105, 26);
            this.студентыToolStripMenuItem.Text = "Студенты ";
            this.студентыToolStripMenuItem.Click += new System.EventHandler(this.студентыToolStripMenuItem_Click);
            // 
            // добавитьОтделениеToolStripMenuItem
            // 
            this.добавитьОтделениеToolStripMenuItem.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.добавитьОтделениеToolStripMenuItem.Name = "добавитьОтделениеToolStripMenuItem";
            this.добавитьОтделениеToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.добавитьОтделениеToolStripMenuItem.Text = "Добавить отделение";
            this.добавитьОтделениеToolStripMenuItem.Click += new System.EventHandler(this.добавитьОтделениеToolStripMenuItem_Click);
            // 
            // добавитьГруппуToolStripMenuItem
            // 
            this.добавитьГруппуToolStripMenuItem.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.добавитьГруппуToolStripMenuItem.Name = "добавитьГруппуToolStripMenuItem";
            this.добавитьГруппуToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.добавитьГруппуToolStripMenuItem.Text = "Добавить группу ";
            this.добавитьГруппуToolStripMenuItem.Click += new System.EventHandler(this.добавитьГруппуToolStripMenuItem_Click);
            // 
            // списокПредметовToolStripMenuItem
            // 
            this.списокПредметовToolStripMenuItem.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.списокПредметовToolStripMenuItem.Name = "списокПредметовToolStripMenuItem";
            this.списокПредметовToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.списокПредметовToolStripMenuItem.Text = "Список предметов";
            this.списокПредметовToolStripMenuItem.Click += new System.EventHandler(this.списокПредметовToolStripMenuItem_Click);
            // 
            // ew3rfToolStripMenuItem
            // 
            this.ew3rfToolStripMenuItem.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ew3rfToolStripMenuItem.Name = "ew3rfToolStripMenuItem";
            this.ew3rfToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.ew3rfToolStripMenuItem.Text = "Список оценок";
            this.ew3rfToolStripMenuItem.Click += new System.EventHandler(this.ew3rfToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Бд.Properties.Resources._86a0f876bf5bd0370750a3da2c17464f;
            this.ClientSize = new System.Drawing.Size(1174, 472);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьПреподавателяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ljToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьОтделениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьГруппуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокПредметовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ew3rfToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
    }
}


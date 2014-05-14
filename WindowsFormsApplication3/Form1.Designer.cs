namespace WindowsFormsApplication3
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.позвонитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.написатьСообщениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.полнаяИнформацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьИсториюСообщенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(69, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.skype;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(2, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 50);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBox1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(6, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(235, 324);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 3;
            this.listBox1.Visible = false;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(2, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 377);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Контакты";
            this.groupBox1.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.позвонитьToolStripMenuItem,
            this.написатьСообщениеToolStripMenuItem,
            this.полнаяИнформацияToolStripMenuItem,
            this.показатьИсториюСообщенийToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(245, 92);
            // 
            // позвонитьToolStripMenuItem
            // 
            this.позвонитьToolStripMenuItem.Name = "позвонитьToolStripMenuItem";
            this.позвонитьToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.позвонитьToolStripMenuItem.Text = "Позвонить";
            this.позвонитьToolStripMenuItem.Click += new System.EventHandler(this.позвонитьToolStripMenuItem_Click);
            // 
            // написатьСообщениеToolStripMenuItem
            // 
            this.написатьСообщениеToolStripMenuItem.Name = "написатьСообщениеToolStripMenuItem";
            this.написатьСообщениеToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.написатьСообщениеToolStripMenuItem.Text = "Написать сообщение";
            this.написатьСообщениеToolStripMenuItem.Click += new System.EventHandler(this.написатьСообщениеToolStripMenuItem_Click);
            // 
            // полнаяИнформацияToolStripMenuItem
            // 
            this.полнаяИнформацияToolStripMenuItem.Name = "полнаяИнформацияToolStripMenuItem";
            this.полнаяИнформацияToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.полнаяИнформацияToolStripMenuItem.Text = "Полная информация...";
            this.полнаяИнформацияToolStripMenuItem.Click += new System.EventHandler(this.полнаяИнформацияToolStripMenuItem_Click);
            // 
            // показатьИсториюСообщенийToolStripMenuItem
            // 
            this.показатьИсториюСообщенийToolStripMenuItem.Name = "показатьИсториюСообщенийToolStripMenuItem";
            this.показатьИсториюСообщенийToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.показатьИсториюСообщенийToolStripMenuItem.Text = "Показать историю сообщений";
            this.показатьИсториюСообщенийToolStripMenuItem.Click += new System.EventHandler(this.показатьИсториюСообщенийToolStripMenuItem_Click);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(288, 66);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox2.Size = new System.Drawing.Size(482, 304);
            this.listBox2.TabIndex = 10;
            this.listBox2.Visible = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "*.txt|*.*";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(582, 434);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 30);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cохранить диалог";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkBox1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(10, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(149, 22);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Только онлайн";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(782, 465);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4Skype";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem позвонитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem написатьСообщениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem полнаяИнформацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьИсториюСообщенийToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
    }
}


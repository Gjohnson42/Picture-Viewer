using System.Drawing.Text;

namespace Picture_Viewer
{
    partial class Viewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.primaryLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ShowBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.backgroundBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.wpnComboBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.stretchCBox = new System.Windows.Forms.CheckBox();
            this.imageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.backgroundColorPicker = new System.Windows.Forms.ColorDialog();
            this.levelNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.primaryLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levelNumericUpDown)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // primaryLayoutPanel
            // 
            this.primaryLayoutPanel.AutoScroll = true;
            this.primaryLayoutPanel.AutoSize = true;
            this.primaryLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.primaryLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.primaryLayoutPanel.ColumnCount = 2;
            this.primaryLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.23144F));
            this.primaryLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.76856F));
            this.primaryLayoutPanel.Controls.Add(this.imageBox, 0, 0);
            this.primaryLayoutPanel.Controls.Add(this.flowLayoutPanel1, 1, 2);
            this.primaryLayoutPanel.Controls.Add(this.stretchCBox, 0, 1);
            this.primaryLayoutPanel.Controls.Add(this.flowLayoutPanel2, 1, 1);
            this.primaryLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.primaryLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.primaryLayoutPanel.Name = "primaryLayoutPanel";
            this.primaryLayoutPanel.RowCount = 3;
            this.primaryLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.18026F));
            this.primaryLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.81974F));
            this.primaryLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.primaryLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.primaryLayoutPanel.Size = new System.Drawing.Size(1173, 493);
            this.primaryLayoutPanel.TabIndex = 0;
            // 
            // imageBox
            // 
            this.primaryLayoutPanel.SetColumnSpan(this.imageBox, 2);
            this.imageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox.Location = new System.Drawing.Point(6, 6);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(1161, 280);
            this.imageBox.TabIndex = 0;
            this.imageBox.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Controls.Add(this.ShowBtn);
            this.flowLayoutPanel1.Controls.Add(this.clearBtn);
            this.flowLayoutPanel1.Controls.Add(this.backgroundBtn);
            this.flowLayoutPanel1.Controls.Add(this.closeBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(221, 387);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(946, 100);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // ShowBtn
            // 
            this.ShowBtn.AutoSize = true;
            this.ShowBtn.BackColor = System.Drawing.SystemColors.Control;
            this.ShowBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ShowBtn.Location = new System.Drawing.Point(844, 3);
            this.ShowBtn.Name = "ShowBtn";
            this.ShowBtn.Size = new System.Drawing.Size(99, 25);
            this.ShowBtn.TabIndex = 0;
            this.ShowBtn.Text = "Show a Picture";
            this.ShowBtn.UseVisualStyleBackColor = false;
            this.ShowBtn.Click += new System.EventHandler(this.ShowBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.AutoSize = true;
            this.clearBtn.BackColor = System.Drawing.SystemColors.Control;
            this.clearBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clearBtn.Location = new System.Drawing.Point(751, 3);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(87, 25);
            this.clearBtn.TabIndex = 1;
            this.clearBtn.Text = "Clear Picture";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // backgroundBtn
            // 
            this.backgroundBtn.AutoSize = true;
            this.backgroundBtn.BackColor = System.Drawing.SystemColors.Control;
            this.backgroundBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.backgroundBtn.Location = new System.Drawing.Point(609, 3);
            this.backgroundBtn.Name = "backgroundBtn";
            this.backgroundBtn.Size = new System.Drawing.Size(136, 25);
            this.backgroundBtn.TabIndex = 2;
            this.backgroundBtn.Text = "Set Background Color";
            this.backgroundBtn.UseVisualStyleBackColor = false;
            this.backgroundBtn.Click += new System.EventHandler(this.backgroundBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.AutoSize = true;
            this.closeBtn.BackColor = System.Drawing.SystemColors.Control;
            this.closeBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.closeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeBtn.Location = new System.Drawing.Point(528, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 25);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // wpnComboBox
            // 
            this.wpnComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wpnComboBox.FormattingEnabled = true;
            this.wpnComboBox.Items.AddRange(new object[] {
            "Axe",
            "Bow",
            "Spear"});
            this.wpnComboBox.Location = new System.Drawing.Point(148, 3);
            this.wpnComboBox.Name = "wpnComboBox";
            this.wpnComboBox.Size = new System.Drawing.Size(121, 21);
            this.wpnComboBox.TabIndex = 5;
            this.wpnComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(3, 6);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(139, 13);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Weapon of Choice:";
            // 
            // stretchCBox
            // 
            this.stretchCBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.stretchCBox.Location = new System.Drawing.Point(69, 295);
            this.stretchCBox.Name = "stretchCBox";
            this.stretchCBox.Size = new System.Drawing.Size(80, 28);
            this.stretchCBox.TabIndex = 1;
            this.stretchCBox.Text = "Stretch";
            this.stretchCBox.UseVisualStyleBackColor = true;
            this.stretchCBox.CheckedChanged += new System.EventHandler(this.stretchCBox_CheckedChanged);
            // 
            // imageFileDialog
            // 
            this.imageFileDialog.FileName = "openFileDialog1";
            this.imageFileDialog.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp";
            this.imageFileDialog.Title = "Select a picture to open...";
            // 
            // levelNumericUpDown
            // 
            this.levelNumericUpDown.Location = new System.Drawing.Point(356, 3);
            this.levelNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.levelNumericUpDown.Name = "levelNumericUpDown";
            this.levelNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.levelNumericUpDown.TabIndex = 1;
            this.levelNumericUpDown.ValueChanged += new System.EventHandler(this.levelNumericUpDown_ValueChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.textBox1);
            this.flowLayoutPanel2.Controls.Add(this.wpnComboBox);
            this.flowLayoutPanel2.Controls.Add(this.textBox2);
            this.flowLayoutPanel2.Controls.Add(this.levelNumericUpDown);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(221, 295);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(946, 83);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(275, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Enhancement";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 493);
            this.Controls.Add(this.primaryLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Viewer";
            this.Text = "Viewer";
            this.primaryLayoutPanel.ResumeLayout(false);
            this.primaryLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levelNumericUpDown)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel primaryLayoutPanel;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.CheckBox stretchCBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ShowBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button backgroundBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.OpenFileDialog imageFileDialog;
        private System.Windows.Forms.ColorDialog backgroundColorPicker;
        private System.Windows.Forms.ComboBox wpnComboBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown levelNumericUpDown;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox textBox2;
    }
}


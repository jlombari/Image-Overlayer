namespace Image_Overlayer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ofd = new OpenFileDialog();
            fileTextBox = new TextBox();
            btnOpen = new Button();
            overlayOption1 = new PictureBox();
            overlayOption2 = new PictureBox();
            overlayOption3 = new PictureBox();
            oo1Radio = new RadioButton();
            oo2Radio = new RadioButton();
            oo3Radio = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)overlayOption1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)overlayOption2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)overlayOption3).BeginInit();
            SuspendLayout();
            // 
            // ofd
            // 
            ofd.DefaultExt = "jpeg";
            ofd.Filter = "PNG Image|*.png|JPG Image|*.jpg|JPEG Image|*.jpeg|All Files|*.*";
            ofd.SelectReadOnly = false;
            ofd.ShowPreview = true;
            ofd.Title = "Select an Image File";
            // 
            // fileTextBox
            // 
            fileTextBox.Location = new Point(12, 29);
            fileTextBox.Name = "fileTextBox";
            fileTextBox.PlaceholderText = "selected image filepath";
            fileTextBox.ReadOnly = true;
            fileTextBox.Size = new Size(357, 23);
            fileTextBox.TabIndex = 0;
            fileTextBox.WordWrap = false;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(375, 29);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(46, 23);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // overlayOption1
            // 
            overlayOption1.BorderStyle = BorderStyle.FixedSingle;
            overlayOption1.Image = Properties.Resources.img_sold_overlay;
            overlayOption1.Location = new Point(12, 73);
            overlayOption1.Name = "overlayOption1";
            overlayOption1.Size = new Size(100, 70);
            overlayOption1.SizeMode = PictureBoxSizeMode.Zoom;
            overlayOption1.TabIndex = 2;
            overlayOption1.TabStop = false;
            // 
            // overlayOption2
            // 
            overlayOption2.BorderStyle = BorderStyle.FixedSingle;
            overlayOption2.Image = Properties.Resources.img_new_overlay1;
            overlayOption2.Location = new Point(154, 73);
            overlayOption2.Name = "overlayOption2";
            overlayOption2.Size = new Size(100, 70);
            overlayOption2.SizeMode = PictureBoxSizeMode.Zoom;
            overlayOption2.TabIndex = 3;
            overlayOption2.TabStop = false;
            // 
            // overlayOption3
            // 
            overlayOption3.BorderStyle = BorderStyle.FixedSingle;
            overlayOption3.Image = Properties.Resources.img_comingsoon_overlay;
            overlayOption3.Location = new Point(312, 73);
            overlayOption3.Name = "overlayOption3";
            overlayOption3.Size = new Size(100, 70);
            overlayOption3.SizeMode = PictureBoxSizeMode.Zoom;
            overlayOption3.TabIndex = 4;
            overlayOption3.TabStop = false;
            // 
            // oo1Radio
            // 
            oo1Radio.AutoSize = true;
            oo1Radio.Location = new Point(52, 149);
            oo1Radio.Name = "oo1Radio";
            oo1Radio.Size = new Size(14, 13);
            oo1Radio.TabIndex = 5;
            oo1Radio.TabStop = true;
            oo1Radio.UseVisualStyleBackColor = true;
            oo1Radio.CheckedChanged += oo1Radio_CheckedChanged;
            // 
            // oo2Radio
            // 
            oo2Radio.AutoSize = true;
            oo2Radio.Location = new Point(195, 149);
            oo2Radio.Name = "oo2Radio";
            oo2Radio.Size = new Size(14, 13);
            oo2Radio.TabIndex = 6;
            oo2Radio.TabStop = true;
            oo2Radio.UseVisualStyleBackColor = true;
            oo2Radio.CheckedChanged += oo2Radio_CheckedChanged;
            // 
            // oo3Radio
            // 
            oo3Radio.AutoSize = true;
            oo3Radio.Location = new Point(355, 149);
            oo3Radio.Name = "oo3Radio";
            oo3Radio.Size = new Size(14, 13);
            oo3Radio.TabIndex = 7;
            oo3Radio.TabStop = true;
            oo3Radio.UseVisualStyleBackColor = true;
            oo3Radio.CheckedChanged += oo3Radio_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 8;
            label1.Text = "Select your image";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 9;
            label2.Text = "Select your overlay";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(292, 181);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(129, 23);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save With Overlay";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 206);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(oo3Radio);
            Controls.Add(oo2Radio);
            Controls.Add(oo1Radio);
            Controls.Add(overlayOption3);
            Controls.Add(overlayOption2);
            Controls.Add(overlayOption1);
            Controls.Add(btnOpen);
            Controls.Add(fileTextBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Image Overlayer - version 0.1";
            ((System.ComponentModel.ISupportInitialize)overlayOption1).EndInit();
            ((System.ComponentModel.ISupportInitialize)overlayOption2).EndInit();
            ((System.ComponentModel.ISupportInitialize)overlayOption3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog ofd;
        private TextBox fileTextBox;
        private Button btnOpen;
        private PictureBox overlayOption1;
        private PictureBox overlayOption2;
        private PictureBox overlayOption3;
        private RadioButton oo1Radio;
        private RadioButton oo2Radio;
        private RadioButton oo3Radio;
        private Label label1;
        private Label label2;
        private Button btnSave;
    }
}

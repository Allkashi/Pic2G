
namespace Pic2gether_
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
            this.ChColor = new System.Windows.Forms.ColorDialog();
            this.BColore = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.NText = new System.Windows.Forms.Label();
            this.BText = new System.Windows.Forms.Button();
            this.NSelect = new System.Windows.Forms.Label();
            this.BSelect = new System.Windows.Forms.Button();
            this.NErase = new System.Windows.Forms.Label();
            this.BErase = new System.Windows.Forms.Button();
            this.NPen = new System.Windows.Forms.Label();
            this.BPen = new System.Windows.Forms.Button();
            this.NFill = new System.Windows.Forms.Label();
            this.BFill = new System.Windows.Forms.Button();
            this.NColor = new System.Windows.Forms.Label();
            this.ZoomPanel = new System.Windows.Forms.Panel();
            this.Canva = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canva)).BeginInit();
            this.SuspendLayout();
            // 
            // BColore
            // 
            this.BColore.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BColore.Location = new System.Drawing.Point(13, 10);
            this.BColore.Name = "BColore";
            this.BColore.Size = new System.Drawing.Size(40, 40);
            this.BColore.TabIndex = 0;
            this.BColore.UseVisualStyleBackColor = false;
            this.BColore.Click += new System.EventHandler(this.ColorChange);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.NText);
            this.splitContainer1.Panel2.Controls.Add(this.BText);
            this.splitContainer1.Panel2.Controls.Add(this.NSelect);
            this.splitContainer1.Panel2.Controls.Add(this.BSelect);
            this.splitContainer1.Panel2.Controls.Add(this.NErase);
            this.splitContainer1.Panel2.Controls.Add(this.BErase);
            this.splitContainer1.Panel2.Controls.Add(this.NPen);
            this.splitContainer1.Panel2.Controls.Add(this.BPen);
            this.splitContainer1.Panel2.Controls.Add(this.NFill);
            this.splitContainer1.Panel2.Controls.Add(this.BFill);
            this.splitContainer1.Panel2.Controls.Add(this.NColor);
            this.splitContainer1.Panel2.Controls.Add(this.BColore);
            this.splitContainer1.Size = new System.Drawing.Size(1143, 73);
            this.splitContainer1.SplitterDistance = 523;
            this.splitContainer1.TabIndex = 1;
            // 
            // NText
            // 
            this.NText.AutoSize = true;
            this.NText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NText.Location = new System.Drawing.Point(306, 53);
            this.NText.Name = "NText";
            this.NText.Size = new System.Drawing.Size(37, 13);
            this.NText.TabIndex = 11;
            this.NText.Text = "Текст";
            this.NText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BText
            // 
            this.BText.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BText.BackgroundImage = global::Pic2gether_.Properties.Resources.Text;
            this.BText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BText.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BText.Location = new System.Drawing.Point(305, 10);
            this.BText.Name = "BText";
            this.BText.Size = new System.Drawing.Size(40, 40);
            this.BText.TabIndex = 10;
            this.BText.UseVisualStyleBackColor = false;
            // 
            // NSelect
            // 
            this.NSelect.AutoSize = true;
            this.NSelect.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NSelect.Location = new System.Drawing.Point(243, 53);
            this.NSelect.Name = "NSelect";
            this.NSelect.Size = new System.Drawing.Size(57, 13);
            this.NSelect.TabIndex = 9;
            this.NSelect.Text = "Выделить";
            this.NSelect.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BSelect
            // 
            this.BSelect.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BSelect.BackgroundImage = global::Pic2gether_.Properties.Resources.Dotted;
            this.BSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BSelect.Location = new System.Drawing.Point(250, 10);
            this.BSelect.Name = "BSelect";
            this.BSelect.Size = new System.Drawing.Size(40, 40);
            this.BSelect.TabIndex = 8;
            this.BSelect.UseVisualStyleBackColor = false;
            // 
            // NErase
            // 
            this.NErase.AutoSize = true;
            this.NErase.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NErase.Location = new System.Drawing.Point(192, 53);
            this.NErase.Name = "NErase";
            this.NErase.Size = new System.Drawing.Size(44, 13);
            this.NErase.TabIndex = 7;
            this.NErase.Text = "Ластик";
            this.NErase.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BErase
            // 
            this.BErase.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BErase.BackgroundImage = global::Pic2gether_.Properties.Resources.Erase;
            this.BErase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BErase.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BErase.Location = new System.Drawing.Point(194, 10);
            this.BErase.Name = "BErase";
            this.BErase.Size = new System.Drawing.Size(40, 40);
            this.BErase.TabIndex = 6;
            this.BErase.UseVisualStyleBackColor = false;
            this.BErase.Click += new System.EventHandler(this.BErase_Click);
            // 
            // NPen
            // 
            this.NPen.AutoSize = true;
            this.NPen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NPen.Location = new System.Drawing.Point(137, 53);
            this.NPen.Name = "NPen";
            this.NPen.Size = new System.Drawing.Size(36, 13);
            this.NPen.TabIndex = 5;
            this.NPen.Text = "Ручка";
            this.NPen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BPen
            // 
            this.BPen.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BPen.BackgroundImage = global::Pic2gether_.Properties.Resources.Pen;
            this.BPen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BPen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BPen.Location = new System.Drawing.Point(136, 10);
            this.BPen.Name = "BPen";
            this.BPen.Size = new System.Drawing.Size(40, 40);
            this.BPen.TabIndex = 4;
            this.BPen.UseVisualStyleBackColor = false;
            this.BPen.Click += new System.EventHandler(this.BPen_Click);
            // 
            // NFill
            // 
            this.NFill.AutoSize = true;
            this.NFill.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NFill.Location = new System.Drawing.Point(70, 53);
            this.NFill.Name = "NFill";
            this.NFill.Size = new System.Drawing.Size(50, 13);
            this.NFill.TabIndex = 3;
            this.NFill.Text = "Заливка";
            this.NFill.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BFill
            // 
            this.BFill.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BFill.BackgroundImage = global::Pic2gether_.Properties.Resources.Fill1;
            this.BFill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BFill.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BFill.Location = new System.Drawing.Point(74, 10);
            this.BFill.Name = "BFill";
            this.BFill.Size = new System.Drawing.Size(40, 40);
            this.BFill.TabIndex = 2;
            this.BFill.UseVisualStyleBackColor = false;
            // 
            // NColor
            // 
            this.NColor.AutoSize = true;
            this.NColor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NColor.Location = new System.Drawing.Point(17, 53);
            this.NColor.Name = "NColor";
            this.NColor.Size = new System.Drawing.Size(32, 13);
            this.NColor.TabIndex = 1;
            this.NColor.Text = "Цвет";
            this.NColor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ZoomPanel
            // 
            this.ZoomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ZoomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ZoomPanel.Location = new System.Drawing.Point(0, 564);
            this.ZoomPanel.Name = "ZoomPanel";
            this.ZoomPanel.Size = new System.Drawing.Size(1143, 20);
            this.ZoomPanel.TabIndex = 2;
            this.ZoomPanel.UseWaitCursor = true;
            // 
            // Canva
            // 
            this.Canva.BackColor = System.Drawing.Color.White;
            this.Canva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Canva.Location = new System.Drawing.Point(0, 0);
            this.Canva.Name = "Canva";
            this.Canva.Size = new System.Drawing.Size(1143, 584);
            this.Canva.TabIndex = 0;
            this.Canva.TabStop = false;
            this.Canva.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canva_MouseDown);
            this.Canva.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canva_MouseMove);
            this.Canva.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canva_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1143, 584);
            this.Controls.Add(this.ZoomPanel);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.Canva);
            this.Name = "Form1";
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Canva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog ChColor;
        private System.Windows.Forms.Button BColore;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label NColor;
        private System.Windows.Forms.PictureBox Canva;
        private System.Windows.Forms.Panel ZoomPanel;
        private System.Windows.Forms.Button BFill;
        private System.Windows.Forms.Label NFill;
        private System.Windows.Forms.Button BPen;
        private System.Windows.Forms.Label NErase;
        private System.Windows.Forms.Button BErase;
        private System.Windows.Forms.Label NPen;
        private System.Windows.Forms.Button BSelect;
        private System.Windows.Forms.Label NSelect;
        private System.Windows.Forms.Label NText;
        private System.Windows.Forms.Button BText;
    }
}


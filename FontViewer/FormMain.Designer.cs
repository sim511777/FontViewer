namespace FontViewer {
   partial class FormMain {
      /// <summary>
      /// 필수 디자이너 변수입니다.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// 사용 중인 모든 리소스를 정리합니다.
      /// </summary>
      /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
      protected override void Dispose(bool disposing) {
         if (disposing && (components != null)) {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form 디자이너에서 생성한 코드

      /// <summary>
      /// 디자이너 지원에 필요한 메서드입니다. 
      /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
      /// </summary>
      private void InitializeComponent() {
         this.panel1 = new System.Windows.Forms.Panel();
         this.tbxExample = new System.Windows.Forms.TextBox();
         this.numFontSize = new System.Windows.Forms.NumericUpDown();
         this.lvwFont = new System.Windows.Forms.ListView();
         this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.panel2 = new System.Windows.Forms.Panel();
         this.tbxDir = new System.Windows.Forms.TextBox();
         this.btnDir = new System.Windows.Forms.Button();
         this.rdoFolder = new System.Windows.Forms.RadioButton();
         this.rdoSystem = new System.Windows.Forms.RadioButton();
         this.dlgFolder = new System.Windows.Forms.FolderBrowserDialog();
         this.panel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.numFontSize)).BeginInit();
         this.panel2.SuspendLayout();
         this.SuspendLayout();
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.tbxExample);
         this.panel1.Controls.Add(this.numFontSize);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel1.Location = new System.Drawing.Point(0, 21);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(790, 21);
         this.panel1.TabIndex = 0;
         // 
         // tbxExample
         // 
         this.tbxExample.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tbxExample.Location = new System.Drawing.Point(53, 0);
         this.tbxExample.Name = "tbxExample";
         this.tbxExample.Size = new System.Drawing.Size(737, 21);
         this.tbxExample.TabIndex = 1;
         this.tbxExample.Text = "brown fox jumps over the lazy dog";
         this.tbxExample.TextChanged += new System.EventHandler(this.tbxExample_TextChanged);
         // 
         // numFontSize
         // 
         this.numFontSize.Dock = System.Windows.Forms.DockStyle.Left;
         this.numFontSize.Location = new System.Drawing.Point(0, 0);
         this.numFontSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this.numFontSize.Name = "numFontSize";
         this.numFontSize.Size = new System.Drawing.Size(53, 21);
         this.numFontSize.TabIndex = 2;
         this.numFontSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
         this.numFontSize.ValueChanged += new System.EventHandler(this.numFontSize_ValueChanged);
         // 
         // lvwFont
         // 
         this.lvwFont.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
         this.lvwFont.Dock = System.Windows.Forms.DockStyle.Fill;
         this.lvwFont.GridLines = true;
         this.lvwFont.Location = new System.Drawing.Point(0, 42);
         this.lvwFont.Name = "lvwFont";
         this.lvwFont.Size = new System.Drawing.Size(790, 604);
         this.lvwFont.TabIndex = 1;
         this.lvwFont.UseCompatibleStateImageBehavior = false;
         this.lvwFont.View = System.Windows.Forms.View.Details;
         // 
         // columnHeader1
         // 
         this.columnHeader1.Text = "Font Name";
         this.columnHeader1.Width = 151;
         // 
         // columnHeader2
         // 
         this.columnHeader2.Text = "Example";
         this.columnHeader2.Width = 1000;
         // 
         // panel2
         // 
         this.panel2.Controls.Add(this.tbxDir);
         this.panel2.Controls.Add(this.btnDir);
         this.panel2.Controls.Add(this.rdoFolder);
         this.panel2.Controls.Add(this.rdoSystem);
         this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel2.Location = new System.Drawing.Point(0, 0);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(790, 21);
         this.panel2.TabIndex = 2;
         // 
         // tbxDir
         // 
         this.tbxDir.BackColor = System.Drawing.SystemColors.Window;
         this.tbxDir.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tbxDir.Location = new System.Drawing.Point(124, 0);
         this.tbxDir.Name = "tbxDir";
         this.tbxDir.ReadOnly = true;
         this.tbxDir.Size = new System.Drawing.Size(639, 21);
         this.tbxDir.TabIndex = 3;
         this.tbxDir.Visible = false;
         this.tbxDir.TextChanged += new System.EventHandler(this.tbxDir_TextChanged);
         // 
         // btnDir
         // 
         this.btnDir.Dock = System.Windows.Forms.DockStyle.Right;
         this.btnDir.Location = new System.Drawing.Point(763, 0);
         this.btnDir.Name = "btnDir";
         this.btnDir.Size = new System.Drawing.Size(27, 21);
         this.btnDir.TabIndex = 2;
         this.btnDir.Text = "...";
         this.btnDir.UseVisualStyleBackColor = true;
         this.btnDir.Visible = false;
         this.btnDir.Click += new System.EventHandler(this.btnDir_Click);
         // 
         // rdoFolder
         // 
         this.rdoFolder.AutoSize = true;
         this.rdoFolder.Dock = System.Windows.Forms.DockStyle.Left;
         this.rdoFolder.Location = new System.Drawing.Point(66, 0);
         this.rdoFolder.Name = "rdoFolder";
         this.rdoFolder.Size = new System.Drawing.Size(58, 21);
         this.rdoFolder.TabIndex = 1;
         this.rdoFolder.Text = "Folder";
         this.rdoFolder.UseVisualStyleBackColor = true;
         // 
         // rdoSystem
         // 
         this.rdoSystem.AutoSize = true;
         this.rdoSystem.Checked = true;
         this.rdoSystem.Dock = System.Windows.Forms.DockStyle.Left;
         this.rdoSystem.Location = new System.Drawing.Point(0, 0);
         this.rdoSystem.Name = "rdoSystem";
         this.rdoSystem.Size = new System.Drawing.Size(66, 21);
         this.rdoSystem.TabIndex = 0;
         this.rdoSystem.TabStop = true;
         this.rdoSystem.Text = "System";
         this.rdoSystem.UseVisualStyleBackColor = true;
         this.rdoSystem.CheckedChanged += new System.EventHandler(this.rdoSystem_CheckedChanged);
         // 
         // FormMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(790, 646);
         this.Controls.Add(this.lvwFont);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.panel2);
         this.Name = "FormMain";
         this.Text = "Font Viewer";
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.numFontSize)).EndInit();
         this.panel2.ResumeLayout(false);
         this.panel2.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.TextBox tbxExample;
      private System.Windows.Forms.NumericUpDown numFontSize;
      private System.Windows.Forms.ListView lvwFont;
      private System.Windows.Forms.ColumnHeader columnHeader1;
      private System.Windows.Forms.ColumnHeader columnHeader2;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.TextBox tbxDir;
      private System.Windows.Forms.Button btnDir;
      private System.Windows.Forms.RadioButton rdoFolder;
      private System.Windows.Forms.RadioButton rdoSystem;
      private System.Windows.Forms.FolderBrowserDialog dlgFolder;
   }
}


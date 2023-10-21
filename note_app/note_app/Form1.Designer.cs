namespace note_app
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
            label1 = new Label();
            txtTitle = new TextBox();
            label2 = new Label();
            txtNotes = new TextBox();
            dgvMsg = new DataGridView();
            btnNew = new Button();
            btnSave = new Button();
            btnRead = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMsg).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "title:";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = SystemColors.GradientActiveCaption;
            txtTitle.BorderStyle = BorderStyle.None;
            txtTitle.Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitle.Location = new Point(56, 12);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(273, 19);
            txtTitle.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 2;
            label2.Text = "notes:";
            // 
            // txtNotes
            // 
            txtNotes.BackColor = SystemColors.GradientActiveCaption;
            txtNotes.BorderStyle = BorderStyle.None;
            txtNotes.Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNotes.Location = new Point(12, 98);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(317, 288);
            txtNotes.TabIndex = 3;
            // 
            // dgvMsg
            // 
            dgvMsg.AllowUserToAddRows = false;
            dgvMsg.AllowUserToDeleteRows = false;
            dgvMsg.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvMsg.BorderStyle = BorderStyle.None;
            dgvMsg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMsg.GridColor = SystemColors.ActiveCaption;
            dgvMsg.Location = new Point(335, 9);
            dgvMsg.Name = "dgvMsg";
            dgvMsg.ReadOnly = true;
            dgvMsg.RowHeadersVisible = false;
            dgvMsg.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvMsg.RowTemplate.Height = 29;
            dgvMsg.Size = new Size(300, 377);
            dgvMsg.TabIndex = 4;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.LightSlateGray;
            btnNew.FlatAppearance.BorderSize = 0;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.ForeColor = SystemColors.ActiveCaptionText;
            btnNew.Location = new Point(12, 392);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 5;
            btnNew.Text = "new";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightSlateGray;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = SystemColors.ActiveCaptionText;
            btnSave.Location = new Point(235, 392);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 6;
            btnSave.Text = "save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnRead
            // 
            btnRead.BackColor = Color.LightSlateGray;
            btnRead.FlatAppearance.BorderSize = 0;
            btnRead.FlatStyle = FlatStyle.Flat;
            btnRead.ForeColor = SystemColors.ActiveCaptionText;
            btnRead.Location = new Point(335, 392);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(94, 29);
            btnRead.TabIndex = 7;
            btnRead.Text = "read";
            btnRead.UseVisualStyleBackColor = false;
            btnRead.Click += btnRead_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightSlateGray;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = SystemColors.ActiveCaptionText;
            btnDelete.Location = new Point(541, 392);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(646, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnRead);
            Controls.Add(btnSave);
            Controls.Add(btnNew);
            Controls.Add(dgvMsg);
            Controls.Add(txtNotes);
            Controls.Add(label2);
            Controls.Add(txtTitle);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMsg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTitle;
        private Label label2;
        private TextBox txtNotes;
        private DataGridView dgvMsg;
        private Button btnNew;
        private Button btnSave;
        private Button btnRead;
        private Button btnDelete;
    }
}
namespace Readers
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
            studentPicture = new PictureBox();
            StudentInfoTextBox = new TextBox();
            passApprovedLabel = new Label();
            ErrorTextBox = new TextBox();
            BookPointBox = new ComboBox();
            label1 = new Label();
            incomingStudentsGrid = new DataGridView();
            number = new DataGridViewTextBoxColumn();
            code = new DataGridViewTextBoxColumn();
            studentName = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)studentPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)incomingStudentsGrid).BeginInit();
            SuspendLayout();
            // 
            // studentPicture
            // 
            studentPicture.BorderStyle = BorderStyle.FixedSingle;
            studentPicture.Image = (Image)resources.GetObject("studentPicture.Image");
            studentPicture.Location = new Point(566, 20);
            studentPicture.Margin = new Padding(3, 2, 3, 2);
            studentPicture.Name = "studentPicture";
            studentPicture.Padding = new Padding(10);
            studentPicture.Size = new Size(263, 294);
            studentPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            studentPicture.TabIndex = 0;
            studentPicture.TabStop = false;
            // 
            // StudentInfoTextBox
            // 
            StudentInfoTextBox.Location = new Point(56, 20);
            StudentInfoTextBox.Margin = new Padding(3, 2, 3, 2);
            StudentInfoTextBox.Multiline = true;
            StudentInfoTextBox.Name = "StudentInfoTextBox";
            StudentInfoTextBox.Size = new Size(148, 207);
            StudentInfoTextBox.TabIndex = 1;
            // 
            // passApprovedLabel
            // 
            passApprovedLabel.AutoSize = true;
            passApprovedLabel.FlatStyle = FlatStyle.Popup;
            passApprovedLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            passApprovedLabel.Location = new Point(639, 316);
            passApprovedLabel.Name = "passApprovedLabel";
            passApprovedLabel.Size = new Size(112, 25);
            passApprovedLabel.TabIndex = 2;
            passApprovedLabel.Text = "Запрещено";
            // 
            // ErrorTextBox
            // 
            ErrorTextBox.Location = new Point(626, 398);
            ErrorTextBox.Margin = new Padding(3, 2, 3, 2);
            ErrorTextBox.Multiline = true;
            ErrorTextBox.Name = "ErrorTextBox";
            ErrorTextBox.Size = new Size(645, 62);
            ErrorTextBox.TabIndex = 3;
            // 
            // BookPointBox
            // 
            BookPointBox.FormattingEnabled = true;
            BookPointBox.Location = new Point(1235, 584);
            BookPointBox.Margin = new Padding(3, 2, 3, 2);
            BookPointBox.Name = "BookPointBox";
            BookPointBox.Size = new Size(156, 23);
            BookPointBox.TabIndex = 5;
            BookPointBox.SelectedIndexChanged += BookPointBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1076, 584);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 6;
            label1.Text = "Пункт книговыдачи";
            // 
            // incomingStudentsGrid
            // 
            incomingStudentsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            incomingStudentsGrid.Columns.AddRange(new DataGridViewColumn[] { number, code, studentName, status });
            incomingStudentsGrid.Location = new Point(56, 365);
            incomingStudentsGrid.Margin = new Padding(3, 2, 3, 2);
            incomingStudentsGrid.Name = "incomingStudentsGrid";
            incomingStudentsGrid.RowHeadersWidth = 51;
            incomingStudentsGrid.RowTemplate.Height = 29;
            incomingStudentsGrid.Size = new Size(478, 215);
            incomingStudentsGrid.TabIndex = 7;
            // 
            // number
            // 
            number.HeaderText = "№";
            number.MinimumWidth = 6;
            number.Name = "number";
            number.ReadOnly = true;
            number.Resizable = DataGridViewTriState.False;
            number.Width = 50;
            // 
            // code
            // 
            code.HeaderText = "Код";
            code.MinimumWidth = 6;
            code.Name = "code";
            code.ReadOnly = true;
            code.Width = 125;
            // 
            // studentName
            // 
            studentName.HeaderText = "ФИО";
            studentName.MinimumWidth = 6;
            studentName.Name = "studentName";
            studentName.ReadOnly = true;
            studentName.Width = 125;
            // 
            // status
            // 
            status.HeaderText = "Статус";
            status.MinimumWidth = 6;
            status.Name = "status";
            status.ReadOnly = true;
            status.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1401, 614);
            Controls.Add(incomingStudentsGrid);
            Controls.Add(label1);
            Controls.Add(BookPointBox);
            Controls.Add(ErrorTextBox);
            Controls.Add(passApprovedLabel);
            Controls.Add(StudentInfoTextBox);
            Controls.Add(studentPicture);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)studentPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)incomingStudentsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox studentPicture;
        private TextBox StudentInfoTextBox;
        private Label passApprovedLabel;
        private TextBox ErrorTextBox;
        private ComboBox BookPointBox;
        private Label label1;
        private DataGridView incomingStudentsGrid;
        private DataGridViewTextBoxColumn number;
        private DataGridViewTextBoxColumn code;
        private DataGridViewTextBoxColumn studentName;
        private DataGridViewTextBoxColumn status;
    }
}

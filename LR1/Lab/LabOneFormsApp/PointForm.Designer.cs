namespace LabOneFormsApp
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
            listBox = new ListBox();
            buttonCreate = new Button();
            buttonSort = new Button();
            buttonSerialize = new Button();
            buttonDeserialize = new Button();
            SuspendLayout();
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(11, 12);
            listBox.Name = "listBox";
            listBox.Size = new Size(442, 229);
            listBox.TabIndex = 0;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(10, 247);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(106, 37);
            buttonCreate.TabIndex = 1;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonSort
            // 
            buttonSort.Location = new Point(122, 247);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(106, 37);
            buttonSort.TabIndex = 2;
            buttonSort.Text = "Sort";
            buttonSort.UseVisualStyleBackColor = true;
            buttonSort.Click += buttonSort_Click;
            // 
            // buttonSerialize
            // 
            buttonSerialize.Location = new Point(234, 247);
            buttonSerialize.Name = "buttonSerialize";
            buttonSerialize.Size = new Size(106, 37);
            buttonSerialize.TabIndex = 3;
            buttonSerialize.Text = "Serialize";
            buttonSerialize.UseVisualStyleBackColor = true;
            buttonSerialize.Click += buttonSerialize_Click;
            // 
            // buttonDeserialize
            // 
            buttonDeserialize.Location = new Point(346, 247);
            buttonDeserialize.Name = "buttonDeserialize";
            buttonDeserialize.Size = new Size(106, 37);
            buttonDeserialize.TabIndex = 4;
            buttonDeserialize.Text = "Deserialize";
            buttonDeserialize.UseVisualStyleBackColor = true;
            buttonDeserialize.Click += buttonDeserialize_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 292);
            Controls.Add(buttonDeserialize);
            Controls.Add(buttonSerialize);
            Controls.Add(buttonSort);
            Controls.Add(buttonCreate);
            Controls.Add(listBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox;
        private Button buttonCreate;
        private Button buttonSort;
        private Button buttonSerialize;
        private Button buttonDeserialize;
    }
}
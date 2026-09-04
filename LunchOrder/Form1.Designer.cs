namespace LunchOrder
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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // radioButton1
            // 
            resources.ApplyResources(radioButton1, "radioButton1");
            radioButton1.Checked = true;
            radioButton1.Name = "radioButton1";
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += this.MainCourse_CheckedChanged;
            // 
            // radioButton2
            // 
            resources.ApplyResources(radioButton2, "radioButton2");
            radioButton2.Name = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += this.MainCourse_CheckedChanged;
            // 
            // radioButton3
            // 
            resources.ApplyResources(radioButton3, "radioButton3");
            radioButton3.Name = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += this.MainCourse_CheckedChanged;
            // 
            // checkBox1
            // 
            resources.ApplyResources(checkBox1, "checkBox1");
            checkBox1.Name = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += this.AddOn_CheckChanged;
            // 
            // checkBox2
            // 
            resources.ApplyResources(checkBox2, "checkBox2");
            checkBox2.Name = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            resources.ApplyResources(checkBox3, "checkBox3");
            checkBox3.Name = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.Name = "textBox1";
            textBox1.TextChanged += this.textBox1_TextChanged;
            // 
            // textBox2
            // 
            resources.ApplyResources(textBox2, "textBox2");
            textBox2.Name = "textBox2";
            // 
            // textBox3
            // 
            resources.ApplyResources(textBox3, "textBox3");
            textBox3.Name = "textBox3";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton3);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            groupBox1.Enter += this.groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBox3);
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            groupBox2.Enter += this.groupBox2_Enter;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.button1_Click;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += this.button2_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(label2);
            resources.ApplyResources(groupBox3, "groupBox3");
            groupBox3.Name = "groupBox3";
            groupBox3.TabStop = false;
            groupBox3.Enter += this.groupBox3_Enter;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Load += this.Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private GroupBox groupBox3;
    }
}

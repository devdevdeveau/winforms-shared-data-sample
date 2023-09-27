namespace Sample;

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
        AccountValueLabel = new Label();
        AccountInfoText = new TextBox();
        UpdateButton = new Button();
        LoadForm2Button = new Button();
        SuspendLayout();
        // 
        // AccountValueLabel
        // 
        AccountValueLabel.AutoSize = true;
        AccountValueLabel.Location = new Point(17, 20);
        AccountValueLabel.Name = "AccountValueLabel";
        AccountValueLabel.Size = new Size(108, 15);
        AccountValueLabel.TabIndex = 0;
        AccountValueLabel.Text = "AccountValueLabel";
        // 
        // AccountInfoText
        // 
        AccountInfoText.Location = new Point(131, 13);
        AccountInfoText.Name = "AccountInfoText";
        AccountInfoText.Size = new Size(100, 23);
        AccountInfoText.TabIndex = 1;
        // 
        // UpdateButton
        // 
        UpdateButton.Location = new Point(237, 12);
        UpdateButton.Name = "UpdateButton";
        UpdateButton.Size = new Size(146, 23);
        UpdateButton.TabIndex = 2;
        UpdateButton.Text = "Update Account Value";
        UpdateButton.UseVisualStyleBackColor = true;
        UpdateButton.Click += UpdateButton_Click;
        // 
        // LoadForm2Button
        // 
        LoadForm2Button.Location = new Point(389, 12);
        LoadForm2Button.Name = "LoadForm2Button";
        LoadForm2Button.Size = new Size(75, 23);
        LoadForm2Button.TabIndex = 3;
        LoadForm2Button.Text = "Load Form2";
        LoadForm2Button.UseVisualStyleBackColor = true;
        LoadForm2Button.Click += LoadForm2Button_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(487, 52);
        Controls.Add(LoadForm2Button);
        Controls.Add(UpdateButton);
        Controls.Add(AccountInfoText);
        Controls.Add(AccountValueLabel);
        Name = "Form1";
        Text = "Form1";
        FormClosed += Form1_FormClosed;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label AccountValueLabel;
    private TextBox AccountInfoText;
    private Button UpdateButton;
    private Button LoadForm2Button;
}

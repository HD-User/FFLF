namespace FFLF;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        urlTextBox = new System.Windows.Forms.TextBox();
        fetchButton = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        extractionProgressBar = new System.Windows.Forms.ProgressBar();
        fetchedTextBox = new System.Windows.Forms.TextBox();
        resultLabel = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // urlTextBox
        // 
        urlTextBox.Location = new System.Drawing.Point(12, 43);
        urlTextBox.Multiline = true;
        urlTextBox.Name = "urlTextBox";
        urlTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        urlTextBox.Size = new System.Drawing.Size(776, 286);
        urlTextBox.TabIndex = 0;
        urlTextBox.WordWrap = false;
        // 
        // fetchButton
        // 
        fetchButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        fetchButton.Location = new System.Drawing.Point(661, 661);
        fetchButton.Name = "fetchButton";
        fetchButton.Size = new System.Drawing.Size(127, 62);
        fetchButton.TabIndex = 1;
        fetchButton.Text = "Fetch!";
        fetchButton.UseVisualStyleBackColor = true;
        fetchButton.Click += fetchButton_Click;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(12, 9);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(162, 31);
        label1.TabIndex = 3;
        label1.Text = "FuckingFast Links";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(12, 332);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(268, 31);
        label2.TabIndex = 4;
        label2.Text = "Fetched Download Links";
        // 
        // extractionProgressBar
        // 
        extractionProgressBar.Location = new System.Drawing.Point(12, 661);
        extractionProgressBar.Name = "extractionProgressBar";
        extractionProgressBar.Size = new System.Drawing.Size(643, 28);
        extractionProgressBar.TabIndex = 5;
        extractionProgressBar.Visible = false;
        // 
        // fetchedTextBox
        // 
        fetchedTextBox.HideSelection = false;
        fetchedTextBox.Location = new System.Drawing.Point(12, 366);
        fetchedTextBox.Multiline = true;
        fetchedTextBox.Name = "fetchedTextBox";
        fetchedTextBox.ReadOnly = true;
        fetchedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        fetchedTextBox.Size = new System.Drawing.Size(776, 289);
        fetchedTextBox.TabIndex = 6;
        fetchedTextBox.WordWrap = false;
        // 
        // resultLabel
        // 
        resultLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        resultLabel.Location = new System.Drawing.Point(12, 692);
        resultLabel.Name = "resultLabel";
        resultLabel.Size = new System.Drawing.Size(643, 31);
        resultLabel.TabIndex = 7;
        resultLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
        // 
        // Form1
        // 
        AcceptButton = fetchButton;
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 736);
        Controls.Add(resultLabel);
        Controls.Add(fetchedTextBox);
        Controls.Add(extractionProgressBar);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(fetchButton);
        Controls.Add(urlTextBox);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        Text = "FuckingFast Link Fetcher";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label resultLabel;

    private System.Windows.Forms.TextBox fetchedTextBox;

    private System.Windows.Forms.ProgressBar extractionProgressBar;

    private System.Windows.Forms.Button fetchButton;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.TextBox urlTextBox;

    #endregion
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace FeelUrFood
{
    public partial class frmLoginPage : Form
    {
        public frmLoginPage()
        {
            InitializeComponent();
            SetCircularButton(Btn1);
            SetCircularButton(Btn2);
            SetCircularButton(Btn3);
            SetCircularButton(Btn4);
            SetCircularButton(Btn5);
            SetCircularButton(Btn6);
            SetCircularButton(Btn7);
            SetCircularButton(Btn8);
            SetCircularButton(Btn9);
            SetCircularButton(Btn0);
            SetCircularButton(ClearBtn);
            SetCircularButton(NextBtn);
            SetRoundedPanel(LoginPanel, 20);
            SetRoundedPanel(PassCodePanel, 20);
            SetRoundedPanel(SwipeCardPanel, 20);
            SetRoundedPanel(panel4, 40);
            SetRoundedPanel(panel5, 40);
            SetRoundedPanel(panel14, 40);
            SetRoundedPanel(panel12, 40);
            SetRoundedPanel(panel10, 40);
            SetRoundedPanel(panel9, 40);

        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED
                return cp;
            }
        }
        private Panel lastClickedPanel = null;
        private int originalPanelSize = 336; // original size
        private int expandedPanelSize = 400; // expanded size
        private int shiftBy = 64; // distance to move the panel to the right

        private void ResetPanel(Panel panel)
        {
            panel.Size = new Size(originalPanelSize, 109); // Reset to original size
            panel.Location = new Point(panel.Location.X - shiftBy, panel.Location.Y); // Move it back to the original position
            panel.BackColor = Color.White;
            LoginLabel.ForeColor = Color.Black;
            PassCodeLabel.ForeColor = Color.Black;
            SwipeCardLabel.ForeColor = Color.Black;
        }
        private void MovePanelToRight(Panel panel)
        {
            panel.Size = new Size(expandedPanelSize, 109); // Increase size
            panel.Location = new Point(panel.Location.X + shiftBy, panel.Location.Y); // Move it to the right
            panel.BackColor = Color.FromArgb(77, 0, 153);
            
            //label11.ForeColor = Color.White;
            //label12.ForeColor = Color.White;
            //label13.ForeColor = Color.White;
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }


        private void SetRoundedPanel(Panel panel, int radius)
        {
            // Ensure that the panel size is being updated correctly before applying the rounded corners.
            GraphicsPath path = new GraphicsPath();

            // Handle the curves on all four corners
            path.AddArc(0, 0, radius, radius, 180, 90); // Top-left corner
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90); // Top-right corner
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90); // Bottom-right corner
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90); // Bottom-left corner

            path.CloseFigure(); // Close the figure to complete the rounded corners

            // Apply the rounded region to the panel
            panel.Region = new Region(path);
        }
        private void SetCircularButton(Button button)
        {
            // Create a path for a circle
            GraphicsPath path = new GraphicsPath();
            int diameter = Math.Min(button.Width, button.Height); // Ensure the button is square for a circle
            path.AddEllipse(0, 0, diameter, diameter);
            path.CloseFigure();

            button.Region = new Region(path); // Set the region to the circle shape

            // Center the text inside the button
            button.TextAlign = ContentAlignment.MiddleCenter; // Center text horizontally and vertically
            button.Padding = new Padding(0);  // Remove extra padding that might cause misalignment
        }
        private void LoginPanel_MouseLeave(object sender, EventArgs e)
        {
            if (lastClickedPanel != LoginPanel)
            {
                LoginPanel.BackColor = Color.White; // Reset background color
                LoginLabel.ForeColor = Color.Black; // Reset label color to black if not the clicked panel
            }
        }
        private void LoginPanel_MouseEnter(object sender, EventArgs e)
        {
                 LoginPanel.BackColor = Color.FromArgb(77, 0, 153);
               LoginLabel.ForeColor = Color.White;  // Set label to white on hover
        }

        private void PassCodePanel_MouseEnter(object sender, EventArgs e)
        {
            PassCodePanel.BackColor = Color.FromArgb(77, 0, 153);
            PassCodeLabel.ForeColor = Color.White;  // Set label to white on hover
        }

        private void PassCodePanel_MouseLeave(object sender, EventArgs e)
        {
            if (lastClickedPanel != PassCodePanel)
            {
                PassCodePanel.BackColor = Color.White; // Reset background color
                PassCodeLabel.ForeColor = Color.Black; // Reset label color to black if not the clicked panel
            }
        }

        private void SwipeCardPanel_MouseEnter(object sender, EventArgs e)
        {
            SwipeCardPanel.BackColor = Color.FromArgb(77, 0, 153);
            SwipeCardLabel.ForeColor = Color.White;  // Set label to white on hover
        }

        private void SwipeCardPanel_MouseLeave(object sender, EventArgs e)
        {
            if (lastClickedPanel != SwipeCardPanel)
            {
                SwipeCardPanel.BackColor = Color.White; // Reset background color
                SwipeCardLabel.ForeColor = Color.Black; // Reset label color to black if not the clicked panel
            }
        }

        private void LoginPanel_Click(object sender, EventArgs e)
        {
            // If panel 6 is clicked, check if it's already expanded
            if (lastClickedPanel != LoginPanel)
            {
                // Reset the previous panel (if any)
                if (lastClickedPanel != null)
                {
                    ResetPanel(lastClickedPanel);
                    LoginPanel.BackColor = Color.White;
                    LoginLabel.ForeColor = Color.Black;
                }

                // Move panel 6 to the right
                MovePanelToRight(LoginPanel);
                LoginLabel.ForeColor = Color.Black;
                LoginPanel.BackColor = Color.FromArgb(77, 0, 153);
                lastClickedPanel = LoginPanel; // Update lastClickedPanel
            }

            // Show only the LoginPanel and hide the others
            panel4.Visible = true;
            panel12.Visible = false;
            panel9.Visible = false;
        }

        private void PassCodePanel_Click(object sender, EventArgs e)
        {
            // If panel 7 is clicked, check if it's already expanded
            if (lastClickedPanel != PassCodePanel)
            {
                // Reset the previous panel (if any)
                if (lastClickedPanel != null)
                {
                    ResetPanel(lastClickedPanel);
                    PassCodePanel.BackColor = Color.White;
                    PassCodeLabel.ForeColor = Color.Black;
                }

                // Move panel 7 to the right
                MovePanelToRight(PassCodePanel);
                PassCodeLabel.ForeColor = Color.Black;
                PassCodePanel.BackColor = Color.FromArgb(77, 0, 153);
                lastClickedPanel = PassCodePanel; // Update lastClickedPanel
            }

            //// Show only the PassCodePanel and hide the others
            panel12.Visible = true;
            panel4.Visible = false;
            panel9.Visible = false;
        }

        private void SwipeCardPanel_Click(object sender, EventArgs e)
        {
            if (lastClickedPanel != SwipeCardPanel)
            {
                // Reset the previous panel (if any)
                if (lastClickedPanel != null)
                {

                    ResetPanel(lastClickedPanel);
                    SwipeCardPanel.BackColor = Color.White;
                    SwipeCardLabel.ForeColor = Color.Black;
                }

                // Move panel 8 to the right
                MovePanelToRight(SwipeCardPanel);
                SwipeCardPanel.ForeColor = Color.FromArgb(77, 0, 153);
                SwipeCardLabel.ForeColor = Color.Black;
                lastClickedPanel = SwipeCardPanel; // Update lastClickedPanel
            }
            // Show only the SwipeCardPanel and hide the others
            panel9.Visible = true;
            panel4.Visible = false;
            panel12.Visible = false;

        }

        private void LoginLabel_MouseEnter(object sender, EventArgs e)
        {
            LoginPanel.BackColor = Color.FromArgb(77, 0, 153);
            LoginLabel.ForeColor = Color.White;  // Set label to white on hover
        }

        private void LoginLabel_MouseLeave(object sender, EventArgs e)
        {
            LoginPanel.BackColor = Color.White;
            LoginLabel.ForeColor = Color.Black;  // Set label to white on hover
        }

        private void PassCodeLabel_MouseEnter(object sender, EventArgs e)
        {
            PassCodePanel.BackColor = Color.FromArgb(77, 0, 153);
            PassCodeLabel.ForeColor = Color.White;  // Set label to white on hover
        }

        private void PassCodeLabel_MouseLeave(object sender, EventArgs e)
        {
            PassCodePanel.BackColor = Color.White;
            PassCodeLabel.ForeColor = Color.Black;  // Set label to white on hover
        }

        private void SwipeCardLabel_MouseEnter(object sender, EventArgs e)
        {
            SwipeCardPanel.BackColor = Color.FromArgb(77, 0, 153);
            SwipeCardLabel.ForeColor = Color.White;  // Set label to white on hover
        }

        private void SwipeCardLabel_MouseLeave(object sender, EventArgs e)
        {
            SwipeCardPanel.BackColor = Color.White;
            SwipeCardLabel.ForeColor = Color.Black;  // Set label to white on hover
        }

        private void LgnBtn_Click(object sender, EventArgs e)
        {
            string username = UserNameTxt.Text;
            string password = PasswordTxt.Text;


            string connectionString = "Server=DESKTOP-TTIL7JI; Database=FeelYourFoodDB ;User Id=sa;password=addsoft;";
            

            string query = "SELECT * FROM AdminLogin WHERE Username = @Username AND Password = @Password AND Status = 1";
            using (SqlConnection connection = new SqlConnection(connectionString)) 
            try
            {

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);


                connection.Open();


                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    // Valid credentials
                    //MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        
                        frmMainDashboard frm = new frmMainDashboard();
                        
                        frm.Show();
                        

                        Application.DoEvents();
                        this.Hide();
                    }
                else
                {
                    // Invalid credentials
                    MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                reader.Close(); // Close the reader
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the database operation
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void NextBtn_Click(object sender, EventArgs e)
        {

        }

        private void PASS1txt_TextChanged(object sender, EventArgs e)
        {
            if (PASS1txt.Text.Length == 1)
            {
                PASS2txt.Focus();  // Move focus to the second textbox
            }
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicAppointmentSystemFrontend
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CustomizeUI(); // Initialize the UI components and layout
        }

        // CustomizeUI: Sets up the layout, colors, and controls of the form
        private void CustomizeUI()
        {
            // Set form properties (title, size, start position, background color)

            // Title Label
            InitializeTitleLabel(); // Adds the title label to the form

            // Sidebar Panel
            InitializeSidebar(); // Adds sidebar panel and buttons to the form

            // Content Panel
            InitializeContentPanel(); // Sets up the main content area with a description label

            // Footer
            InitializeFooter(); // Adds a footer label to the form
        }

        // InitializeTitleLabel: Adds a label at the top of the form as the title
        private void InitializeTitleLabel()
        {
            Label titleLabel = new Label
            {
                Text = "Clinic Appointment System",
                Font = new Font("Arial", 18, FontStyle.Bold),
                ForeColor = Color.DarkSlateBlue,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Height = 60
            };
            this.Controls.Add(titleLabel);
        }

        // InitializeSidebar: Sets up the sidebar with buttons for navigation
        private void InitializeSidebar()
        {
            Panel sidebarPanel = new Panel
            {
                BackColor = Color.LightSlateGray,
                Width = 150,
                Dock = DockStyle.Left
            };
            this.Controls.Add(sidebarPanel);

            // Adding buttons for "Patients", "Doctors", and "Appointments" with their positioning
            Button btnPatients = CreateSidebarButton("Patients", 20);
            Button btnDoctors = CreateSidebarButton("Doctors", 80);
            Button btnAppointments = CreateSidebarButton("Appointments", 140);

            sidebarPanel.Controls.Add(btnPatients);
            sidebarPanel.Controls.Add(btnDoctors);
            sidebarPanel.Controls.Add(btnAppointments);
        }

        // CreateSidebarButton: Helper method to create styled sidebar buttons
        private Button CreateSidebarButton(string text, int top)
        {
            return new Button
            {
                Text = text,
                Size = new Size(120, 40),
                Location = new Point(15, top),
                BackColor = Color.DeepSkyBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Arial", 10, FontStyle.Regular)
            };
        }

        // InitializeContentPanel: Configures the main content panel where descriptions are shown
        private void InitializeContentPanel()
        {
            Panel contentPanel = new Panel
            {
                BackColor = Color.White,
                Dock = DockStyle.Fill,
                Padding = new Padding(20) // Ensure margins are sufficient for visibility
            };
            this.Controls.Add(contentPanel);

            Label descriptionLabel = new Label
            {
                Text = "Welcome to the Clinic Appointment System!\n\n" +
                       "Here you can manage appointments, doctors, and patients.",
                Font = new Font("Arial", 12),
                ForeColor = Color.DarkSlateGray,
                TextAlign = ContentAlignment.TopLeft,
                Dock = DockStyle.Fill,
                AutoSize = false,
                Padding = new Padding(15, 10, 10, 10), // Left padding to prevent text clipping
                Cursor = Cursors.IBeam // Cursor change to allow text selection
            };
            contentPanel.Controls.Add(descriptionLabel);
        }

        // InitializeFooter: Adds a footer label at the bottom of the form
        private void InitializeFooter()
        {
            Label footerLabel = new Label
            {
                Text = "© 2024 Clinic Appointment System",
                Font = new Font("Arial", 10, FontStyle.Italic),
                ForeColor = Color.Gray,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Bottom,
                Height = 30
            };
            this.Controls.Add(footerLabel);
        }
    }
}
using System.Windows;

namespace TaskManager
{
    public partial class TaskDialog : Window
    {
        public Task NewTask { get; set; }

        public TaskDialog(Task taskToEdit = null)
        {
            InitializeComponent();

            if (taskToEdit != null)
            {
                NewTask = taskToEdit;
                titleTextBox.Text = NewTask.Title;
                descriptionTextBox.Text = NewTask.Description;
                priorityTextBox.Text = NewTask.Priority;
                statusTextBox.Text = NewTask.Status;
            }
            else
            {
                NewTask = new Task(); 
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            NewTask.Title = titleTextBox.Text;
            NewTask.Description = descriptionTextBox.Text;
            NewTask.Priority = priorityTextBox.Text;
            NewTask.Status = statusTextBox.Text;

            DialogResult = true;
        }
    }
}
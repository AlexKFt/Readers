using Readers.Models;
using System.Web;

namespace Readers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Task.Factory.StartNew(startThreads);
        }

        int myIDP = -1;


        public void startThreads()
        {
            OracleBiblioRepository biblioRepository;
            UniverRepository univerRepository;
            List<BookPoint> bookPoints;
            try
            {
                //biblioRepository = OracleBiblioRepository.getInstance();
                //bookPoints = biblioRepository.getBookPoints();
                bookPoints = new List<BookPoint>() { new (1, "One" ), new (2, "Two"), new (3, "Three"), new (4, "������� �����") };
                Invoke(() =>
                {
                    BookPointBox.Items.AddRange(bookPoints.ToArray<object>());
                    BookPointBox.DisplayMember = "Name";
                });
                var bookPoint = bookPoints.Find(b => b.Name == System.Configuration.ConfigurationSettings.AppSettings["BookPointName"]);
                if (bookPoint != null)
                {
                    myIDP = bookPoint.Id; //��������� �������� ����� ������� ������ ������.
                    Invoke(() => BookPointBox.SelectedItem = BookPointBox.Items[BookPointBox.Items.IndexOf(bookPoint)]);
                }
                else
                {
                    ErrorTextBox.Text = "���������� ���� ������!";
                }
                //univerRepository = UniverRepository.getInstance();
            }
            catch (Exception ex)
            {
                ErrorTextBox.Invoke(() => Text = ex.Message);
                //�������� �� ���-������ ����������.
            }

            Thread.Sleep(3);

            Queue<string> students = new();

            Thread reading = new Thread(() =>
            {
                while (true)
                {
                    string code = Console.ReadLine();
                    Invoke(() => { students.Enqueue(code); });
                }
            });
            reading.Start();

            Thread callingDb = new Thread(() =>
            {
                int showTime = 1000 * Int32.Parse(System.Configuration.ConfigurationSettings.AppSettings["studentShowTime"]);
                while (true)
                {
                    if (students.TryPeek(out string code))
                    {
                        students.Dequeue();
                        Invoke(() => { StudentInfoTextBox.Text  = "����1:\n��������1\n����2:\n��������2\n����3:\n��������3"; });
                        //StudentUniver univerResponse = univerRepository.getStudent(code);
                        Invoke(() => incomingStudentsGrid.Rows.Add(1, "333333", "��� �.�.", "��������"));
                        //StudentBiblio biblioResponse = biblioRepository.getStudent(univerResponse);
                        //Invoke(() => { studentPicture.ImageLocation = biblioResponse.Image; });
                        bool studentStatus = false;
                        if (studentStatus)
                        {
                            Invoke(() => 
                            { 
                                passApprovedLabel.BackColor = Color.Lime;
                                passApprovedLabel.Text = "������ ��������";
                                studentPicture.BackColor = Color.Lime;
                            });
                        }
                        else
                        {
                            Invoke(() => 
                            { 
                                passApprovedLabel.BackColor = Color.Red;
                                passApprovedLabel.Text = "������ ��������";
                                studentPicture.BackColor = Color.Red;
                            });
                        }
                        Thread.Sleep(showTime);
                    }
                }
            });
            callingDb.Start();
        }

        private void BookPointBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            myIDP = ((BookPoint)BookPointBox.SelectedItem).Id;//���� �� ����� ��������, ������ ��� � ������ �������� ���� ��������.
        }
    }


}

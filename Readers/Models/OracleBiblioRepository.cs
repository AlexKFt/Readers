using Oracle.ManagedDataAccess.Client;

using System.Data;

namespace Readers.Models
{
    public class OracleBiblioRepository
    {
        private BiblioContext db;
        private static OracleBiblioRepository instance;

        public static OracleBiblioRepository getInstance()
        {
            if (instance == null)
                instance = new OracleBiblioRepository();
            return instance;
        }

        private OracleBiblioRepository()
        {
            db = new BiblioContext("LIB", "id_logic", "IDL");
            db.connect();
        }

        public List<BookPoint> getBookPoints()
        {
            OracleParameter bookPoints = new OracleParameter();
            bookPoints.Direction = ParameterDirection.Output;
            bookPoints.ParameterName = "Bookpoints";
            bookPoints.OracleDbType = OracleDbType.Varchar2;
            bookPoints.Size = 1024;

            List<OracleParameter> oraParams = new() { bookPoints };
            var res = db.callProcedure("MSCIENCE", "GetBookPoints", oraParams);

            var bookPointsList = new List<BookPoint>();
            var points_str = res["Bookpoints"].ToString().Split("^"); //!!!!!!!!!!!!!!!!Another split charackter

            foreach (var p in points_str)
            {
                var values = p.Split(",");
                BookPoint bp = new(Int32.Parse(values[0]), values[1]);
                bookPointsList.Add(bp);
            }

            return bookPointsList;
        }

        public StudentBiblio getStudent(string readerId, string userLogin, string bookPoint) //Лучше передавать цельный ответ от базы института вместе с пунктов выдачи.
        {
            OracleParameter ClientRfidLabel = new OracleParameter();
            ClientRfidLabel.Direction = ParameterDirection.Input;
            ClientRfidLabel.ParameterName = "ClientRfidLabe";
            ClientRfidLabel.OracleDbType = OracleDbType.Varchar2;
            ClientRfidLabel.Size = 16;
            ClientRfidLabel.Value = readerId;

            OracleParameter UserLogin = new OracleParameter();
            UserLogin.Direction = ParameterDirection.Input;
            UserLogin.ParameterName = "UserLogin";
            UserLogin.OracleDbType = OracleDbType.Varchar2;
            UserLogin.Size = 32;
            UserLogin.Value = userLogin;

            OracleParameter BookPoint = new OracleParameter();
            BookPoint.Direction = ParameterDirection.Input;
            BookPoint.ParameterName = "BookPoint";
            BookPoint.OracleDbType = OracleDbType.Varchar2;
            BookPoint.Size = 255;
            BookPoint.Value = userLogin;

            OracleParameter Fio = new OracleParameter();
            Fio.Direction = ParameterDirection.Output;
            Fio.ParameterName = "Fio";
            Fio.OracleDbType = OracleDbType.Varchar2;
            Fio.Size = 255;

            OracleParameter Pin = new OracleParameter();
            Pin.Direction = ParameterDirection.Output;
            Pin.ParameterName = "Pin";
            Pin.OracleDbType = OracleDbType.Varchar2;
            Pin.Size = 32;

            OracleParameter Code = new OracleParameter();
            Code.Direction = ParameterDirection.Output;
            Code.ParameterName = "Code";
            Code.OracleDbType = OracleDbType.Varchar2;
            Code.Size = 255;

            OracleParameter Email = new OracleParameter();
            Email.Direction = ParameterDirection.Output;
            Email.ParameterName = "Email";
            Email.OracleDbType = OracleDbType.Varchar2;
            Email.Size = 255;

            OracleParameter Employment = new OracleParameter();
            Employment.Direction = ParameterDirection.Output;
            Employment.ParameterName = "Employment";
            Employment.OracleDbType = OracleDbType.Varchar2;
            Employment.Size = 255;

            OracleParameter Course = new OracleParameter();
            Course.Direction = ParameterDirection.Output;
            Course.ParameterName = "Course";
            Course.OracleDbType = OracleDbType.Varchar2;
            Course.Size = 255;

            OracleParameter Cost1 = new OracleParameter();
            Cost1.Direction = ParameterDirection.Output;
            Cost1.ParameterName = "Cost1";
            Cost1.OracleDbType = OracleDbType.Varchar2;
            Cost1.Size = 255;

            OracleParameter Notes = new OracleParameter();
            Notes.Direction = ParameterDirection.Output;
            Notes.ParameterName = "Notes";
            Notes.OracleDbType = OracleDbType.Varchar2;
            Notes.Size = 255;

            OracleParameter Custom1 = new OracleParameter();
            Custom1.Direction = ParameterDirection.Output;
            Custom1.ParameterName = "Custom1";
            Custom1.OracleDbType = OracleDbType.Varchar2;
            Custom1.Size = 128;

            OracleParameter Custom2 = new OracleParameter();
            Custom2.Direction = ParameterDirection.Output;
            Custom2.ParameterName = "Custom2";
            Custom2.OracleDbType = OracleDbType.Varchar2;
            Custom2.Size = 128;

            OracleParameter Cntorders = new OracleParameter();
            Cntorders.Direction = ParameterDirection.Output;
            Cntorders.ParameterName = "Cntorders";
            Cntorders.OracleDbType = OracleDbType.Int32;

            OracleParameter Cntonhand = new OracleParameter();
            Cntonhand.Direction = ParameterDirection.Output;
            Cntonhand.ParameterName = "Cntonhand";
            Cntonhand.OracleDbType = OracleDbType.Int32;

            OracleParameter Cntredate = new OracleParameter();
            Cntredate.Direction = ParameterDirection.Output;
            Cntredate.ParameterName = "Cntredate";
            Cntredate.OracleDbType = OracleDbType.Int32;

            OracleParameter Status = new OracleParameter();
            Status.Direction = ParameterDirection.Output;
            Status.ParameterName = "Status";
            Status.OracleDbType = OracleDbType.Int32; //Number

            OracleParameter ErrMessage = new OracleParameter();
            ErrMessage.Direction = ParameterDirection.Output;
            ErrMessage.ParameterName = "ErrMessage";
            ErrMessage.OracleDbType = OracleDbType.Varchar2;
            ErrMessage.Size = 255;

            List<OracleParameter> oraParams = new();
            oraParams.Add(ClientRfidLabel);
            oraParams.Add(UserLogin);
            oraParams.Add(BookPoint);
            oraParams.Add(Fio);
            oraParams.Add(Pin);
            oraParams.Add(Code);
            oraParams.Add(Email);
            oraParams.Add(Employment);
            oraParams.Add(Course);
            oraParams.Add(Cost1);
            oraParams.Add(Notes);
            oraParams.Add(Custom1);
            oraParams.Add(Custom2);
            oraParams.Add(Cntorders);
            oraParams.Add(Cntonhand);
            oraParams.Add(Cntredate);
            oraParams.Add(Status);
            oraParams.Add(ErrMessage);

            var res = db.callProcedure("MSCIENCE", "READERS_GETCLIENTINFO", oraParams);

            return new StudentBiblio(res);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class Client : Base
    {
        private int _id;
        private string _name;
        private string _fatherName;
        private string _motherName;
        private string _gender;
        private DateTime _dob;
        private string _pan;
        private string _aadhar;
        private string _placeOfBirth;
        private bool _isMarried;
        private DateTime? _marriageAnniversyDate;
        private string _occupation;
        private string _incomeSlab;
        private string _imagePath;
        private string _imageData;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string FatherName
        {
            get { return _fatherName; }
            set { _fatherName = value; }
        }
        public string MotherName
        {
            get { return _motherName; }
            set { _motherName = value; }
        }
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public DateTime DOB
        {
            get { return _dob; }
            set { _dob = value; }
        }
        public string PAN
        {
            get { return _pan; }
            set { _pan = value; }
        }
        public string Aadhar
        {
            get { return _aadhar; }
            set { _aadhar = value; }
        }
        public string PlaceOfBirth
        {
            get { return _placeOfBirth; }
            set { _placeOfBirth = value; }
        }
        public bool IsMarried
        {
            get { return _isMarried; }
            set { _isMarried = value; }
        }
        public DateTime? MarriageAnniversary
        {
            get { return _marriageAnniversyDate; }
            set { _marriageAnniversyDate = value; }
        }
        public string Occupation
        {
            get { return _occupation; }
            set { _occupation = value; }
        }
        public string IncomeSlab
        {
            get { return _incomeSlab; }
            set { _incomeSlab = value; }
        }
        public string ImagePath
        {
            get { return _imagePath; }
            set { _imagePath = value; }
        }
        public string ImageData
        {
            get { return _imageData; }
            set { _imageData = value; }
        }
    }
}

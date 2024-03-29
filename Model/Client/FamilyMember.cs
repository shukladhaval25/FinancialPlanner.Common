﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public class FamilyMember : Base
    {
        int _id;
        int _cid;
        string _name;
        string _relationship;
        DateTime? _dob;
        bool _isDependent;
        string _ChildrenClass;
        string _description;
        string _pancard;
        string _aadharCard;
        string _occupation;
        bool _isHuf;

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public int Cid
        {
            get
            {
                return _cid;
            }

            set
            {
                _cid = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string Relationship
        {
            get
            {
                return _relationship;
            }

            set
            {
                _relationship = value;
            }
        }

        public DateTime? DOB
        {
            get
            {
                return _dob;
            }

            set
            {
                _dob = value;
            }
        }

        public bool IsDependent
        {
            get
            {
                return _isDependent;
            }

            set
            {
                _isDependent = value;
            }
        }

        public string ChildrenClass
        {
            get
            {
                return _ChildrenClass;
            }

            set
            {
                _ChildrenClass = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
            }
        }

        public string Pancard { get => _pancard; set => _pancard = value; }
        public string AadharCard { get => _aadharCard; set => _aadharCard = value; }
        public string Occupation { get => _occupation; set => _occupation = value; }
        public bool IsHuf { get => _isHuf; set => _isHuf = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace workin
{
    class mydict<No,Name>
    {
        No[] _no;
        No[] _tempNo;
        Name[] _name;
        Name[] _tempName;
        public mydict()
        {
            _name = new Name[0];
            _no = new No[0];
        }

        public void Add(No no,Name name)
        {
            _tempName = _name;
            _tempNo = _no;
            _name = new Name[_name.Length + 1];
            _no = new No[_no.Length + 1];
            for (int i = 0; i < _tempNo.Length; i++)
            {
                _name[i] = _tempName[i];
                _no[i] = _tempNo[i];
            }
            _no[_no.Length - 1] = no;
            _name[_name.Length - 1] = name;
        }

    }
}

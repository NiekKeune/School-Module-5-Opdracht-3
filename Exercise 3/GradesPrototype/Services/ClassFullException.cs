﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GradesPrototype.Services
{
    [Serializable]
    class ClassFullException : Exception
    {
        private string _className;
        public virtual string ClassName
        {
            get
            {
                return _className;
            }
        }
        
        public ClassFullException()
        {
        }

        public ClassFullException(string message)
            : base(message)
        {
        }

        public ClassFullException(string message, Exception inner)
            : base(message, inner)
        {
        }

        public ClassFullException(string message, string cls)
            : base(message)
        {
            _className = cls;
        }

        public ClassFullException(string message, string cls, Exception inner)
            : base(message, inner)
        {
            _className = cls;
        }       

        #region Code provided to handle deserialization of a custom exception
        // Constructor for deserializing a ClassFullException object
        // The _className field contains custom data, so it must be handled explicitly
        // The details are outside the scope of this lab
        protected ClassFullException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            // Populate the _className member from the deserialization stream 
            _className = info.GetString("ClassName");
        }


        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
            {
                throw new ArgumentException("info");
            }
            base.GetObjectData(info, context);
            info.AddValue("ClassName", _className, typeof(string));
        }
        #endregion
    }
}

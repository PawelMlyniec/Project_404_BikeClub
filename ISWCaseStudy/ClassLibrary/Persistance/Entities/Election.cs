﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó mediante una herramienta.
//     Los cambios del archivo se perderán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------
namespace BikeClubLib.Entities
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public partial class Election
	{
        private DateTime dateTime;

        public Election(DateTime dateTime)
        {
            this.dateTime = dateTime;
        }

        public DateTime StartDate
		{
			get;
			set;
		}

		public virtual int ID
		{
			get;
			set;
		}

		public virtual Member President
		{
			get;
			set;
		}

		public virtual ICollection<Votes> Votes
		{
			get;
			set;
		}

	}
}


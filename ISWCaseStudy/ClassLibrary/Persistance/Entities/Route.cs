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
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    public partial class Route
	{
        [Key]
		public string Name
		{
			get;
			set;
		}

		public string Start
		{
			get;
			set;
		}

		public string End
		{
			get;
			set;
		}

		public int Distance
		{
			get;
			set;
		}

		public int Ramp
		{
			get;
			set;
		}

		public Difficulty Difficulty
		{
			get;
			set;
		}

		public virtual ICollection<SomeDaysEvent> SomeDaysEvent
		{
			get;
			set;
		}

	}
}


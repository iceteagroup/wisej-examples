using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModalWorkflow
{
	public class UserData : ICloneable
	{
		public UserData()
		{
			this.AccountCreation = DateTime.Now;
			this.AccountExpiration = DateTime.Now;
		}


		public string Name
		{
			get;
			set;
		}

		public string LastName
		{
			get;
			set;
		}

		public UserRole Role
		{
			get;
			set;
		}

		public DateTime AccountCreation
		{
			get;
			set;
		}

		public DateTime AccountExpiration
		{
			get;
			set;
		}

		public object Clone()
		{
			return MemberwiseClone();
		}
	}

	public enum UserRole
	{
		User,
		Contributor,
		Editor,
		Administrator
	}
}
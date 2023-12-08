using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.porn
{
	/// <summary>
	/// it can be, depending on its <see cref="_rank.Scale_"/>,
	///		-normal
	///			,it's not porn
	///		- warned
	///			,the user is warned
	///		- restricted
	///			,only some user, such as those are adult, can view
	///		- quarantined
	///			, temporarily or permanently unavailable
	///		- sealed
	///			, the content is deemed <see cref="_rank.Scale_.Forbidden"/> and it will be moved to a place no body can have access to. (it can be referenced, but its content is not shown to anyone)
	///		- trashed
	///			, the content is put into a trash, and dereferenced. it's only used for logging purpose.
	///		
	///			
	/// </summary>
	internal class IStore
	{
	}
}

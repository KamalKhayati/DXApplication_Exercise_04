/****************************** Ghost.github.io ******************************\
*	Module Name:	History.cs
*	Project:		DXApplication_Exercise_04
*	Copyright (C) 2018 Kamal Khayati, All rights reserved.
*	This software may be modified and distributed under the terms of the MIT license.  See LICENSE file for details.
*
*	Written by Kamal Khayati <Kamal1355@gmail.com>,  2018 / 11 / 28   06:03 ب.ظ
*	
***********************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication_Exercise_04
{
    [Table("Histors")]
    public class Histor
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string DatePass { get; set; }
        public string GroupName { get; set; }
        public int TrueItem { get; set; }
        public int FalseItem { get; set; }
        public int NoneItem { get; set; }
    }
}

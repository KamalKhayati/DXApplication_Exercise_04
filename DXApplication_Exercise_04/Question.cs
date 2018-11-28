/****************************** Ghost.github.io ******************************\
*	Module Name:	Question.cs
*	Project:		DXApplication_Exercise_04
*	Copyright (C) 2018 Kamal Khayati, All rights reserved.
*	This software may be modified and distributed under the terms of the MIT license.  See LICENSE file for details.
*
*	Written by Kamal Khayati <Kamal1355@gmail.com>,  2018 / 11 / 28   06:02 ب.ظ
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
    [Table("Questions")]
    public class Question
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int GroupId { get; set; }
        public string Class { get; set; }
        public string QuestionText { get; set; }
        public string Case1 { get; set; }
        public string Case2 { get; set; }
        public string Case3 { get; set; }
        public string Case4 { get; set; }
        public int Answer { get; set; }
    }
}

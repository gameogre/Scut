﻿/****************************************************************************
Copyright (c) 2013-2015 scutgame.com

http://www.scutgame.com

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProtoBuf;
using ZyGames.Framework.Common;
using ZyGames.Framework.Model;

namespace ZyGames.Framework.Game.Message
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable, ProtoContract]
    [EntityTable("", "", 0, "")]
    public class MailMessage : BaseEntity
    {
        /// <summary>
        /// </summary>
        public MailMessage()
            : base(AccessLevel.ReadWrite)
        {
        }

        /// <summary>
        /// </summary>
        public MailMessage(Guid MailID)
            : this()
        {
            this._MailID = MailID;
        }

        #region 自动生成属性

        private Guid _MailID;
        /// <summary>
        /// </summary>        
        [ProtoMember(1)]
        [EntityField("MailID", IsKey = true, DbType = ColumnDbType.UniqueIdentifier)]
        public virtual Guid MailID
        {
            get
            {
                return _MailID;
            }

        }

        private Int32 _UserId;
        /// <summary>
        /// </summary>        
        [ProtoMember(2)]
        [EntityField("UserId")]
        public virtual Int32 UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                SetChange("UserId", value);
            }
        }

        private Int32 _MailType;
        /// <summary>
        /// </summary>        
        [ProtoMember(3)]
        [EntityField("MailType")]
        public virtual Int32 MailType
        {
            get
            {
                return _MailType;
            }
            set
            {
                SetChange("MailType", value);
            }
        }

        private Int32 _FromUserId;
        /// <summary>
        /// </summary>        
        [ProtoMember(4)]
        [EntityField("FromUserId")]
        public virtual Int32 FromUserId
        {
            get
            {
                return _FromUserId;
            }
            set
            {
                SetChange("FromUserId", value);
            }
        }

        private String _FromUserName;
        /// <summary>
        /// </summary>        
        [ProtoMember(5)]
        [EntityField("FromUserName")]
        public virtual String FromUserName
        {
            get
            {
                return _FromUserName;
            }
            set
            {
                SetChange("FromUserName", value);
            }
        }

        private Int32 _ToUserID;
        /// <summary>
        /// </summary>        
        [ProtoMember(6)]
        [EntityField("ToUserID")]
        public virtual Int32 ToUserID
        {
            get
            {
                return _ToUserID;
            }
            set
            {
                SetChange("ToUserID", value);
            }
        }

        private String _ToUserName;
        /// <summary>
        /// </summary>        
        [ProtoMember(7)]
        [EntityField("ToUserName")]
        public virtual String ToUserName
        {
            get
            {
                return _ToUserName;
            }
            set
            {
                SetChange("ToUserName", value);
            }
        }

        private String _Title;
        /// <summary>
        /// </summary>        
        [ProtoMember(8)]
        [EntityField("Title")]
        public virtual String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                SetChange("Title", value);
            }
        }

        private String _Content;
        /// <summary>
        /// </summary>        
        [ProtoMember(9)]
        [EntityField("Content")]
        public virtual String Content
        {
            get
            {
                return _Content;
            }
            set
            {
                SetChange("Content", value);
            }
        }

        private DateTime _SendDate;
        /// <summary>
        /// </summary>        
        [ProtoMember(10)]
        [EntityField("SendDate")]
        public virtual DateTime SendDate
        {
            get
            {
                return _SendDate;
            }
            set
            {
                SetChange("SendDate", value);
            }
        }

        private Boolean _IsRead;
        /// <summary>
        /// </summary>        
        [ProtoMember(11)]
        [EntityField("IsRead")]
        public virtual Boolean IsRead
        {
            get
            {
                return _IsRead;
            }
            set
            {
                SetChange("IsRead", value);
            }
        }

        private Boolean _IsRemove;
        /// <summary>
        /// </summary>        
        [ProtoMember(12)]
        [EntityField("IsRemove")]
        public virtual Boolean IsRemove
        {
            get
            {
                return _IsRemove;
            }
            set
            {
                SetChange("IsRemove", value);
            }
        }

        private DateTime _RemoveDate;
        /// <summary>
        /// </summary>        
        [ProtoMember(13)]
        [EntityField("RemoveDate")]
        public virtual DateTime RemoveDate
        {
            get
            {
                return _RemoveDate;
            }
            set
            {
                SetChange("RemoveDate", value);
            }
        }

        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "MailID": return MailID;
                    case "UserId": return UserId;
                    case "MailType": return MailType;
                    case "FromUserId": return FromUserId;
                    case "FromUserName": return FromUserName;
                    case "ToUserID": return ToUserID;
                    case "ToUserName": return ToUserName;
                    case "Title": return Title;
                    case "Content": return Content;
                    case "SendDate": return SendDate;
                    case "IsRead": return IsRead;
                    case "IsRemove": return IsRemove;
                    case "RemoveDate": return RemoveDate;
                    default: throw new ArgumentException(string.Format("MailMessage index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "MailID":
                        _MailID = (Guid)value;
                        break;
                    case "UserId":
                        _UserId = value.ToInt();
                        break;
                    case "MailType":
                        _MailType = value.ToInt();
                        break;
                    case "FromUserId":
                        _FromUserId = value.ToInt();
                        break;
                    case "FromUserName":
                        _FromUserName = value.ToNotNullString();
                        break;
                    case "ToUserID":
                        _ToUserID = value.ToInt();
                        break;
                    case "ToUserName":
                        _ToUserName = value.ToNotNullString();
                        break;
                    case "Title":
                        _Title = value.ToNotNullString();
                        break;
                    case "Content":
                        _Content = value.ToNotNullString();
                        break;
                    case "SendDate":
                        _SendDate = value.ToDateTime();
                        break;
                    case "IsRead":
                        _IsRead = value.ToBool();
                        break;
                    case "IsRemove":
                        _IsRemove = value.ToBool();
                        break;
                    case "RemoveDate":
                        _RemoveDate = value.ToDateTime();
                        break;
                    default: throw new ArgumentException(string.Format("MailMessage index[{0}] isn't exist.", index));
                }
                #endregion
            }
        }

        #endregion

        protected override int GetIdentityId()
        {
            return UserId;
        }
    }
}
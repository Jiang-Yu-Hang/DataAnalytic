/*
               File: type_SdtSYS_User
        Description: SYS_User
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:8:55.92
       Program type: Callable routine
          Main DBMS: SQL Server
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using System.Web.Services.Protocols;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Reflection;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   [XmlSerializerFormat]
   [XmlRoot(ElementName = "SYS_User" )]
   [XmlType(TypeName =  "SYS_User" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtSYS_User : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSYS_User( )
      {
      }

      public SdtSYS_User( IGxContext context )
      {
         this.context = context;
         constructorCallingAssembly = Assembly.GetCallingAssembly();
         initialize();
      }

      private static Hashtable mapper;
      public override String JsonMap( String value )
      {
         if ( mapper == null )
         {
            mapper = new Hashtable();
         }
         return (String)mapper[value]; ;
      }

      public void Load( Guid AV359UserID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(Guid)AV359UserID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"UserID", typeof(Guid)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "SYS_User");
         metadata.Set("BT", "SYS_USER");
         metadata.Set("PK", "[ \"UserID\" ]");
         metadata.Set("PKAssigned", "[ \"UserID\" ]");
         metadata.Set("AllowInsert", "True");
         metadata.Set("AllowUpdate", "True");
         metadata.Set("AllowDelete", "True");
         return metadata ;
      }

      public override GeneXus.Utils.GxStringCollection StateAttributes( )
      {
         GeneXus.Utils.GxStringCollection state = new GeneXus.Utils.GxStringCollection() ;
         state.Add("gxTpr_Mode");
         state.Add("gxTpr_Initialized");
         state.Add("gxTpr_Userid_Z");
         state.Add("gxTpr_Displayname_Z");
         state.Add("gxTpr_Usertype_Z");
         state.Add("gxTpr_Account_Z");
         state.Add("gxTpr_Passwordhash_Z");
         state.Add("gxTpr_Loginip_Z");
         state.Add("gxTpr_Logintime_Z_Nullable");
         state.Add("gxTpr_Sys_usercreator_Z");
         state.Add("gxTpr_Sys_usercreatetime_Z_Nullable");
         state.Add("gxTpr_Sys_usermodifier_Z");
         state.Add("gxTpr_Sys_usermodifytime_Z_Nullable");
         state.Add("gxTpr_Sys_userisdeleted_Z");
         state.Add("gxTpr_Email_Z");
         state.Add("gxTpr_Rocheaccount_Z");
         state.Add("gxTpr_Loginip_N");
         state.Add("gxTpr_Logintime_N");
         state.Add("gxTpr_Sys_usermodifier_N");
         state.Add("gxTpr_Sys_usermodifytime_N");
         state.Add("gxTpr_Email_N");
         state.Add("gxTpr_Sys_userdescription_N");
         state.Add("gxTpr_Rocheaccount_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtSYS_User sdt ;
         sdt = (SdtSYS_User)(source);
         gxTv_SdtSYS_User_Userid = sdt.gxTv_SdtSYS_User_Userid ;
         gxTv_SdtSYS_User_Displayname = sdt.gxTv_SdtSYS_User_Displayname ;
         gxTv_SdtSYS_User_Usertype = sdt.gxTv_SdtSYS_User_Usertype ;
         gxTv_SdtSYS_User_Account = sdt.gxTv_SdtSYS_User_Account ;
         gxTv_SdtSYS_User_Passwordhash = sdt.gxTv_SdtSYS_User_Passwordhash ;
         gxTv_SdtSYS_User_Loginip = sdt.gxTv_SdtSYS_User_Loginip ;
         gxTv_SdtSYS_User_Logintime = sdt.gxTv_SdtSYS_User_Logintime ;
         gxTv_SdtSYS_User_Sys_usercreator = sdt.gxTv_SdtSYS_User_Sys_usercreator ;
         gxTv_SdtSYS_User_Sys_usercreatetime = sdt.gxTv_SdtSYS_User_Sys_usercreatetime ;
         gxTv_SdtSYS_User_Sys_usermodifier = sdt.gxTv_SdtSYS_User_Sys_usermodifier ;
         gxTv_SdtSYS_User_Sys_usermodifytime = sdt.gxTv_SdtSYS_User_Sys_usermodifytime ;
         gxTv_SdtSYS_User_Sys_userisdeleted = sdt.gxTv_SdtSYS_User_Sys_userisdeleted ;
         gxTv_SdtSYS_User_Email = sdt.gxTv_SdtSYS_User_Email ;
         gxTv_SdtSYS_User_Sys_userdescription = sdt.gxTv_SdtSYS_User_Sys_userdescription ;
         gxTv_SdtSYS_User_Rocheaccount = sdt.gxTv_SdtSYS_User_Rocheaccount ;
         gxTv_SdtSYS_User_Mode = sdt.gxTv_SdtSYS_User_Mode ;
         gxTv_SdtSYS_User_Initialized = sdt.gxTv_SdtSYS_User_Initialized ;
         gxTv_SdtSYS_User_Userid_Z = sdt.gxTv_SdtSYS_User_Userid_Z ;
         gxTv_SdtSYS_User_Displayname_Z = sdt.gxTv_SdtSYS_User_Displayname_Z ;
         gxTv_SdtSYS_User_Usertype_Z = sdt.gxTv_SdtSYS_User_Usertype_Z ;
         gxTv_SdtSYS_User_Account_Z = sdt.gxTv_SdtSYS_User_Account_Z ;
         gxTv_SdtSYS_User_Passwordhash_Z = sdt.gxTv_SdtSYS_User_Passwordhash_Z ;
         gxTv_SdtSYS_User_Loginip_Z = sdt.gxTv_SdtSYS_User_Loginip_Z ;
         gxTv_SdtSYS_User_Logintime_Z = sdt.gxTv_SdtSYS_User_Logintime_Z ;
         gxTv_SdtSYS_User_Sys_usercreator_Z = sdt.gxTv_SdtSYS_User_Sys_usercreator_Z ;
         gxTv_SdtSYS_User_Sys_usercreatetime_Z = sdt.gxTv_SdtSYS_User_Sys_usercreatetime_Z ;
         gxTv_SdtSYS_User_Sys_usermodifier_Z = sdt.gxTv_SdtSYS_User_Sys_usermodifier_Z ;
         gxTv_SdtSYS_User_Sys_usermodifytime_Z = sdt.gxTv_SdtSYS_User_Sys_usermodifytime_Z ;
         gxTv_SdtSYS_User_Sys_userisdeleted_Z = sdt.gxTv_SdtSYS_User_Sys_userisdeleted_Z ;
         gxTv_SdtSYS_User_Email_Z = sdt.gxTv_SdtSYS_User_Email_Z ;
         gxTv_SdtSYS_User_Rocheaccount_Z = sdt.gxTv_SdtSYS_User_Rocheaccount_Z ;
         gxTv_SdtSYS_User_Loginip_N = sdt.gxTv_SdtSYS_User_Loginip_N ;
         gxTv_SdtSYS_User_Logintime_N = sdt.gxTv_SdtSYS_User_Logintime_N ;
         gxTv_SdtSYS_User_Sys_usermodifier_N = sdt.gxTv_SdtSYS_User_Sys_usermodifier_N ;
         gxTv_SdtSYS_User_Sys_usermodifytime_N = sdt.gxTv_SdtSYS_User_Sys_usermodifytime_N ;
         gxTv_SdtSYS_User_Email_N = sdt.gxTv_SdtSYS_User_Email_N ;
         gxTv_SdtSYS_User_Sys_userdescription_N = sdt.gxTv_SdtSYS_User_Sys_userdescription_N ;
         gxTv_SdtSYS_User_Rocheaccount_N = sdt.gxTv_SdtSYS_User_Rocheaccount_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("UserID", gxTv_SdtSYS_User_Userid, false);
         AddObjectProperty("DisplayName", gxTv_SdtSYS_User_Displayname, false);
         AddObjectProperty("UserType", gxTv_SdtSYS_User_Usertype, false);
         AddObjectProperty("Account", gxTv_SdtSYS_User_Account, false);
         AddObjectProperty("PasswordHash", gxTv_SdtSYS_User_Passwordhash, false);
         AddObjectProperty("LoginIP", gxTv_SdtSYS_User_Loginip, false);
         AddObjectProperty("LoginIP_N", gxTv_SdtSYS_User_Loginip_N, false);
         datetime_STZ = gxTv_SdtSYS_User_Logintime;
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "T";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + ":";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + ":";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("LoginTime", sDateCnv, false);
         AddObjectProperty("LoginTime_N", gxTv_SdtSYS_User_Logintime_N, false);
         AddObjectProperty("SYS_UserCreator", gxTv_SdtSYS_User_Sys_usercreator, false);
         datetime_STZ = gxTv_SdtSYS_User_Sys_usercreatetime;
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "T";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + ":";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + ":";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("SYS_UserCreateTime", sDateCnv, false);
         AddObjectProperty("SYS_UserModifier", gxTv_SdtSYS_User_Sys_usermodifier, false);
         AddObjectProperty("SYS_UserModifier_N", gxTv_SdtSYS_User_Sys_usermodifier_N, false);
         datetime_STZ = gxTv_SdtSYS_User_Sys_usermodifytime;
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "T";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + ":";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + ":";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("SYS_UserModifyTime", sDateCnv, false);
         AddObjectProperty("SYS_UserModifyTime_N", gxTv_SdtSYS_User_Sys_usermodifytime_N, false);
         AddObjectProperty("SYS_UserIsDeleted", gxTv_SdtSYS_User_Sys_userisdeleted, false);
         AddObjectProperty("Email", gxTv_SdtSYS_User_Email, false);
         AddObjectProperty("Email_N", gxTv_SdtSYS_User_Email_N, false);
         AddObjectProperty("SYS_UserDescription", gxTv_SdtSYS_User_Sys_userdescription, false);
         AddObjectProperty("SYS_UserDescription_N", gxTv_SdtSYS_User_Sys_userdescription_N, false);
         AddObjectProperty("RocheAccount", gxTv_SdtSYS_User_Rocheaccount, false);
         AddObjectProperty("RocheAccount_N", gxTv_SdtSYS_User_Rocheaccount_N, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtSYS_User_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtSYS_User_Initialized, false);
            AddObjectProperty("UserID_Z", gxTv_SdtSYS_User_Userid_Z, false);
            AddObjectProperty("DisplayName_Z", gxTv_SdtSYS_User_Displayname_Z, false);
            AddObjectProperty("UserType_Z", gxTv_SdtSYS_User_Usertype_Z, false);
            AddObjectProperty("Account_Z", gxTv_SdtSYS_User_Account_Z, false);
            AddObjectProperty("PasswordHash_Z", gxTv_SdtSYS_User_Passwordhash_Z, false);
            AddObjectProperty("LoginIP_Z", gxTv_SdtSYS_User_Loginip_Z, false);
            datetime_STZ = gxTv_SdtSYS_User_Logintime_Z;
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "T";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("LoginTime_Z", sDateCnv, false);
            AddObjectProperty("SYS_UserCreator_Z", gxTv_SdtSYS_User_Sys_usercreator_Z, false);
            datetime_STZ = gxTv_SdtSYS_User_Sys_usercreatetime_Z;
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "T";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("SYS_UserCreateTime_Z", sDateCnv, false);
            AddObjectProperty("SYS_UserModifier_Z", gxTv_SdtSYS_User_Sys_usermodifier_Z, false);
            datetime_STZ = gxTv_SdtSYS_User_Sys_usermodifytime_Z;
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "T";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("SYS_UserModifyTime_Z", sDateCnv, false);
            AddObjectProperty("SYS_UserIsDeleted_Z", gxTv_SdtSYS_User_Sys_userisdeleted_Z, false);
            AddObjectProperty("Email_Z", gxTv_SdtSYS_User_Email_Z, false);
            AddObjectProperty("RocheAccount_Z", gxTv_SdtSYS_User_Rocheaccount_Z, false);
            AddObjectProperty("LoginIP_N", gxTv_SdtSYS_User_Loginip_N, false);
            AddObjectProperty("LoginTime_N", gxTv_SdtSYS_User_Logintime_N, false);
            AddObjectProperty("SYS_UserModifier_N", gxTv_SdtSYS_User_Sys_usermodifier_N, false);
            AddObjectProperty("SYS_UserModifyTime_N", gxTv_SdtSYS_User_Sys_usermodifytime_N, false);
            AddObjectProperty("Email_N", gxTv_SdtSYS_User_Email_N, false);
            AddObjectProperty("SYS_UserDescription_N", gxTv_SdtSYS_User_Sys_userdescription_N, false);
            AddObjectProperty("RocheAccount_N", gxTv_SdtSYS_User_Rocheaccount_N, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtSYS_User sdt )
      {
         if ( sdt.IsDirty("UserID") )
         {
            gxTv_SdtSYS_User_Userid = sdt.gxTv_SdtSYS_User_Userid ;
         }
         if ( sdt.IsDirty("DisplayName") )
         {
            gxTv_SdtSYS_User_Displayname = sdt.gxTv_SdtSYS_User_Displayname ;
         }
         if ( sdt.IsDirty("UserType") )
         {
            gxTv_SdtSYS_User_Usertype = sdt.gxTv_SdtSYS_User_Usertype ;
         }
         if ( sdt.IsDirty("Account") )
         {
            gxTv_SdtSYS_User_Account = sdt.gxTv_SdtSYS_User_Account ;
         }
         if ( sdt.IsDirty("PasswordHash") )
         {
            gxTv_SdtSYS_User_Passwordhash = sdt.gxTv_SdtSYS_User_Passwordhash ;
         }
         if ( sdt.IsDirty("LoginIP") )
         {
            gxTv_SdtSYS_User_Loginip = sdt.gxTv_SdtSYS_User_Loginip ;
         }
         if ( sdt.IsDirty("LoginTime") )
         {
            gxTv_SdtSYS_User_Logintime = sdt.gxTv_SdtSYS_User_Logintime ;
         }
         if ( sdt.IsDirty("SYS_UserCreator") )
         {
            gxTv_SdtSYS_User_Sys_usercreator = sdt.gxTv_SdtSYS_User_Sys_usercreator ;
         }
         if ( sdt.IsDirty("SYS_UserCreateTime") )
         {
            gxTv_SdtSYS_User_Sys_usercreatetime = sdt.gxTv_SdtSYS_User_Sys_usercreatetime ;
         }
         if ( sdt.IsDirty("SYS_UserModifier") )
         {
            gxTv_SdtSYS_User_Sys_usermodifier = sdt.gxTv_SdtSYS_User_Sys_usermodifier ;
         }
         if ( sdt.IsDirty("SYS_UserModifyTime") )
         {
            gxTv_SdtSYS_User_Sys_usermodifytime = sdt.gxTv_SdtSYS_User_Sys_usermodifytime ;
         }
         if ( sdt.IsDirty("SYS_UserIsDeleted") )
         {
            gxTv_SdtSYS_User_Sys_userisdeleted = sdt.gxTv_SdtSYS_User_Sys_userisdeleted ;
         }
         if ( sdt.IsDirty("Email") )
         {
            gxTv_SdtSYS_User_Email = sdt.gxTv_SdtSYS_User_Email ;
         }
         if ( sdt.IsDirty("SYS_UserDescription") )
         {
            gxTv_SdtSYS_User_Sys_userdescription = sdt.gxTv_SdtSYS_User_Sys_userdescription ;
         }
         if ( sdt.IsDirty("RocheAccount") )
         {
            gxTv_SdtSYS_User_Rocheaccount = sdt.gxTv_SdtSYS_User_Rocheaccount ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "UserID" )]
      [  XmlElement( ElementName = "UserID"   )]
      public Guid gxTpr_Userid
      {
         get {
            return gxTv_SdtSYS_User_Userid ;
         }

         set {
            if ( gxTv_SdtSYS_User_Userid != value )
            {
               gxTv_SdtSYS_User_Mode = "INS";
               this.gxTv_SdtSYS_User_Userid_Z_SetNull( );
               this.gxTv_SdtSYS_User_Displayname_Z_SetNull( );
               this.gxTv_SdtSYS_User_Usertype_Z_SetNull( );
               this.gxTv_SdtSYS_User_Account_Z_SetNull( );
               this.gxTv_SdtSYS_User_Passwordhash_Z_SetNull( );
               this.gxTv_SdtSYS_User_Loginip_Z_SetNull( );
               this.gxTv_SdtSYS_User_Logintime_Z_SetNull( );
               this.gxTv_SdtSYS_User_Sys_usercreator_Z_SetNull( );
               this.gxTv_SdtSYS_User_Sys_usercreatetime_Z_SetNull( );
               this.gxTv_SdtSYS_User_Sys_usermodifier_Z_SetNull( );
               this.gxTv_SdtSYS_User_Sys_usermodifytime_Z_SetNull( );
               this.gxTv_SdtSYS_User_Sys_userisdeleted_Z_SetNull( );
               this.gxTv_SdtSYS_User_Email_Z_SetNull( );
               this.gxTv_SdtSYS_User_Rocheaccount_Z_SetNull( );
            }
            gxTv_SdtSYS_User_Userid = (Guid)(value);
            SetDirty("Userid");
         }

      }

      [  SoapElement( ElementName = "DisplayName" )]
      [  XmlElement( ElementName = "DisplayName"   )]
      public String gxTpr_Displayname
      {
         get {
            return gxTv_SdtSYS_User_Displayname ;
         }

         set {
            gxTv_SdtSYS_User_Displayname = value;
            SetDirty("Displayname");
         }

      }

      [  SoapElement( ElementName = "UserType" )]
      [  XmlElement( ElementName = "UserType"   )]
      public int gxTpr_Usertype
      {
         get {
            return gxTv_SdtSYS_User_Usertype ;
         }

         set {
            gxTv_SdtSYS_User_Usertype = value;
            SetDirty("Usertype");
         }

      }

      [  SoapElement( ElementName = "Account" )]
      [  XmlElement( ElementName = "Account"   )]
      public String gxTpr_Account
      {
         get {
            return gxTv_SdtSYS_User_Account ;
         }

         set {
            gxTv_SdtSYS_User_Account = value;
            SetDirty("Account");
         }

      }

      [  SoapElement( ElementName = "PasswordHash" )]
      [  XmlElement( ElementName = "PasswordHash"   )]
      public String gxTpr_Passwordhash
      {
         get {
            return gxTv_SdtSYS_User_Passwordhash ;
         }

         set {
            gxTv_SdtSYS_User_Passwordhash = value;
            SetDirty("Passwordhash");
         }

      }

      [  SoapElement( ElementName = "LoginIP" )]
      [  XmlElement( ElementName = "LoginIP"   )]
      public String gxTpr_Loginip
      {
         get {
            return gxTv_SdtSYS_User_Loginip ;
         }

         set {
            gxTv_SdtSYS_User_Loginip_N = 0;
            gxTv_SdtSYS_User_Loginip = value;
            SetDirty("Loginip");
         }

      }

      public void gxTv_SdtSYS_User_Loginip_SetNull( )
      {
         gxTv_SdtSYS_User_Loginip_N = 1;
         gxTv_SdtSYS_User_Loginip = "";
         return  ;
      }

      public bool gxTv_SdtSYS_User_Loginip_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "LoginTime" )]
      [  XmlElement( ElementName = "LoginTime"  , IsNullable=true )]
      public string gxTpr_Logintime_Nullable
      {
         get {
            if ( gxTv_SdtSYS_User_Logintime == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtSYS_User_Logintime).value ;
         }

         set {
            gxTv_SdtSYS_User_Logintime_N = 0;
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtSYS_User_Logintime = DateTime.MinValue;
            else
               gxTv_SdtSYS_User_Logintime = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Logintime
      {
         get {
            return gxTv_SdtSYS_User_Logintime ;
         }

         set {
            gxTv_SdtSYS_User_Logintime_N = 0;
            gxTv_SdtSYS_User_Logintime = value;
            SetDirty("Logintime");
         }

      }

      public void gxTv_SdtSYS_User_Logintime_SetNull( )
      {
         gxTv_SdtSYS_User_Logintime_N = 1;
         gxTv_SdtSYS_User_Logintime = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtSYS_User_Logintime_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_UserCreator" )]
      [  XmlElement( ElementName = "SYS_UserCreator"   )]
      public String gxTpr_Sys_usercreator
      {
         get {
            return gxTv_SdtSYS_User_Sys_usercreator ;
         }

         set {
            gxTv_SdtSYS_User_Sys_usercreator = value;
            SetDirty("Sys_usercreator");
         }

      }

      [  SoapElement( ElementName = "SYS_UserCreateTime" )]
      [  XmlElement( ElementName = "SYS_UserCreateTime"  , IsNullable=true )]
      public string gxTpr_Sys_usercreatetime_Nullable
      {
         get {
            if ( gxTv_SdtSYS_User_Sys_usercreatetime == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtSYS_User_Sys_usercreatetime).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtSYS_User_Sys_usercreatetime = DateTime.MinValue;
            else
               gxTv_SdtSYS_User_Sys_usercreatetime = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Sys_usercreatetime
      {
         get {
            return gxTv_SdtSYS_User_Sys_usercreatetime ;
         }

         set {
            gxTv_SdtSYS_User_Sys_usercreatetime = value;
            SetDirty("Sys_usercreatetime");
         }

      }

      [  SoapElement( ElementName = "SYS_UserModifier" )]
      [  XmlElement( ElementName = "SYS_UserModifier"   )]
      public String gxTpr_Sys_usermodifier
      {
         get {
            return gxTv_SdtSYS_User_Sys_usermodifier ;
         }

         set {
            gxTv_SdtSYS_User_Sys_usermodifier_N = 0;
            gxTv_SdtSYS_User_Sys_usermodifier = value;
            SetDirty("Sys_usermodifier");
         }

      }

      public void gxTv_SdtSYS_User_Sys_usermodifier_SetNull( )
      {
         gxTv_SdtSYS_User_Sys_usermodifier_N = 1;
         gxTv_SdtSYS_User_Sys_usermodifier = "";
         return  ;
      }

      public bool gxTv_SdtSYS_User_Sys_usermodifier_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_UserModifyTime" )]
      [  XmlElement( ElementName = "SYS_UserModifyTime"  , IsNullable=true )]
      public string gxTpr_Sys_usermodifytime_Nullable
      {
         get {
            if ( gxTv_SdtSYS_User_Sys_usermodifytime == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtSYS_User_Sys_usermodifytime).value ;
         }

         set {
            gxTv_SdtSYS_User_Sys_usermodifytime_N = 0;
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtSYS_User_Sys_usermodifytime = DateTime.MinValue;
            else
               gxTv_SdtSYS_User_Sys_usermodifytime = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Sys_usermodifytime
      {
         get {
            return gxTv_SdtSYS_User_Sys_usermodifytime ;
         }

         set {
            gxTv_SdtSYS_User_Sys_usermodifytime_N = 0;
            gxTv_SdtSYS_User_Sys_usermodifytime = value;
            SetDirty("Sys_usermodifytime");
         }

      }

      public void gxTv_SdtSYS_User_Sys_usermodifytime_SetNull( )
      {
         gxTv_SdtSYS_User_Sys_usermodifytime_N = 1;
         gxTv_SdtSYS_User_Sys_usermodifytime = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtSYS_User_Sys_usermodifytime_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_UserIsDeleted" )]
      [  XmlElement( ElementName = "SYS_UserIsDeleted"   )]
      public short gxTpr_Sys_userisdeleted
      {
         get {
            return gxTv_SdtSYS_User_Sys_userisdeleted ;
         }

         set {
            gxTv_SdtSYS_User_Sys_userisdeleted = value;
            SetDirty("Sys_userisdeleted");
         }

      }

      [  SoapElement( ElementName = "Email" )]
      [  XmlElement( ElementName = "Email"   )]
      public String gxTpr_Email
      {
         get {
            return gxTv_SdtSYS_User_Email ;
         }

         set {
            gxTv_SdtSYS_User_Email_N = 0;
            gxTv_SdtSYS_User_Email = value;
            SetDirty("Email");
         }

      }

      public void gxTv_SdtSYS_User_Email_SetNull( )
      {
         gxTv_SdtSYS_User_Email_N = 1;
         gxTv_SdtSYS_User_Email = "";
         return  ;
      }

      public bool gxTv_SdtSYS_User_Email_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_UserDescription" )]
      [  XmlElement( ElementName = "SYS_UserDescription"   )]
      public String gxTpr_Sys_userdescription
      {
         get {
            return gxTv_SdtSYS_User_Sys_userdescription ;
         }

         set {
            gxTv_SdtSYS_User_Sys_userdescription_N = 0;
            gxTv_SdtSYS_User_Sys_userdescription = value;
            SetDirty("Sys_userdescription");
         }

      }

      public void gxTv_SdtSYS_User_Sys_userdescription_SetNull( )
      {
         gxTv_SdtSYS_User_Sys_userdescription_N = 1;
         gxTv_SdtSYS_User_Sys_userdescription = "";
         return  ;
      }

      public bool gxTv_SdtSYS_User_Sys_userdescription_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "RocheAccount" )]
      [  XmlElement( ElementName = "RocheAccount"   )]
      public String gxTpr_Rocheaccount
      {
         get {
            return gxTv_SdtSYS_User_Rocheaccount ;
         }

         set {
            gxTv_SdtSYS_User_Rocheaccount_N = 0;
            gxTv_SdtSYS_User_Rocheaccount = value;
            SetDirty("Rocheaccount");
         }

      }

      public void gxTv_SdtSYS_User_Rocheaccount_SetNull( )
      {
         gxTv_SdtSYS_User_Rocheaccount_N = 1;
         gxTv_SdtSYS_User_Rocheaccount = "";
         return  ;
      }

      public bool gxTv_SdtSYS_User_Rocheaccount_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtSYS_User_Mode ;
         }

         set {
            gxTv_SdtSYS_User_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtSYS_User_Mode_SetNull( )
      {
         gxTv_SdtSYS_User_Mode = "";
         return  ;
      }

      public bool gxTv_SdtSYS_User_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtSYS_User_Initialized ;
         }

         set {
            gxTv_SdtSYS_User_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtSYS_User_Initialized_SetNull( )
      {
         gxTv_SdtSYS_User_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtSYS_User_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "UserID_Z" )]
      [  XmlElement( ElementName = "UserID_Z"   )]
      public Guid gxTpr_Userid_Z
      {
         get {
            return gxTv_SdtSYS_User_Userid_Z ;
         }

         set {
            gxTv_SdtSYS_User_Userid_Z = (Guid)(value);
            SetDirty("Userid_Z");
         }

      }

      public void gxTv_SdtSYS_User_Userid_Z_SetNull( )
      {
         gxTv_SdtSYS_User_Userid_Z = (Guid)(Guid.Empty);
         return  ;
      }

      public bool gxTv_SdtSYS_User_Userid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "DisplayName_Z" )]
      [  XmlElement( ElementName = "DisplayName_Z"   )]
      public String gxTpr_Displayname_Z
      {
         get {
            return gxTv_SdtSYS_User_Displayname_Z ;
         }

         set {
            gxTv_SdtSYS_User_Displayname_Z = value;
            SetDirty("Displayname_Z");
         }

      }

      public void gxTv_SdtSYS_User_Displayname_Z_SetNull( )
      {
         gxTv_SdtSYS_User_Displayname_Z = "";
         return  ;
      }

      public bool gxTv_SdtSYS_User_Displayname_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "UserType_Z" )]
      [  XmlElement( ElementName = "UserType_Z"   )]
      public int gxTpr_Usertype_Z
      {
         get {
            return gxTv_SdtSYS_User_Usertype_Z ;
         }

         set {
            gxTv_SdtSYS_User_Usertype_Z = value;
            SetDirty("Usertype_Z");
         }

      }

      public void gxTv_SdtSYS_User_Usertype_Z_SetNull( )
      {
         gxTv_SdtSYS_User_Usertype_Z = 0;
         return  ;
      }

      public bool gxTv_SdtSYS_User_Usertype_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Account_Z" )]
      [  XmlElement( ElementName = "Account_Z"   )]
      public String gxTpr_Account_Z
      {
         get {
            return gxTv_SdtSYS_User_Account_Z ;
         }

         set {
            gxTv_SdtSYS_User_Account_Z = value;
            SetDirty("Account_Z");
         }

      }

      public void gxTv_SdtSYS_User_Account_Z_SetNull( )
      {
         gxTv_SdtSYS_User_Account_Z = "";
         return  ;
      }

      public bool gxTv_SdtSYS_User_Account_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "PasswordHash_Z" )]
      [  XmlElement( ElementName = "PasswordHash_Z"   )]
      public String gxTpr_Passwordhash_Z
      {
         get {
            return gxTv_SdtSYS_User_Passwordhash_Z ;
         }

         set {
            gxTv_SdtSYS_User_Passwordhash_Z = value;
            SetDirty("Passwordhash_Z");
         }

      }

      public void gxTv_SdtSYS_User_Passwordhash_Z_SetNull( )
      {
         gxTv_SdtSYS_User_Passwordhash_Z = "";
         return  ;
      }

      public bool gxTv_SdtSYS_User_Passwordhash_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "LoginIP_Z" )]
      [  XmlElement( ElementName = "LoginIP_Z"   )]
      public String gxTpr_Loginip_Z
      {
         get {
            return gxTv_SdtSYS_User_Loginip_Z ;
         }

         set {
            gxTv_SdtSYS_User_Loginip_Z = value;
            SetDirty("Loginip_Z");
         }

      }

      public void gxTv_SdtSYS_User_Loginip_Z_SetNull( )
      {
         gxTv_SdtSYS_User_Loginip_Z = "";
         return  ;
      }

      public bool gxTv_SdtSYS_User_Loginip_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "LoginTime_Z" )]
      [  XmlElement( ElementName = "LoginTime_Z"  , IsNullable=true )]
      public string gxTpr_Logintime_Z_Nullable
      {
         get {
            if ( gxTv_SdtSYS_User_Logintime_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtSYS_User_Logintime_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtSYS_User_Logintime_Z = DateTime.MinValue;
            else
               gxTv_SdtSYS_User_Logintime_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Logintime_Z
      {
         get {
            return gxTv_SdtSYS_User_Logintime_Z ;
         }

         set {
            gxTv_SdtSYS_User_Logintime_Z = value;
            SetDirty("Logintime_Z");
         }

      }

      public void gxTv_SdtSYS_User_Logintime_Z_SetNull( )
      {
         gxTv_SdtSYS_User_Logintime_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtSYS_User_Logintime_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_UserCreator_Z" )]
      [  XmlElement( ElementName = "SYS_UserCreator_Z"   )]
      public String gxTpr_Sys_usercreator_Z
      {
         get {
            return gxTv_SdtSYS_User_Sys_usercreator_Z ;
         }

         set {
            gxTv_SdtSYS_User_Sys_usercreator_Z = value;
            SetDirty("Sys_usercreator_Z");
         }

      }

      public void gxTv_SdtSYS_User_Sys_usercreator_Z_SetNull( )
      {
         gxTv_SdtSYS_User_Sys_usercreator_Z = "";
         return  ;
      }

      public bool gxTv_SdtSYS_User_Sys_usercreator_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_UserCreateTime_Z" )]
      [  XmlElement( ElementName = "SYS_UserCreateTime_Z"  , IsNullable=true )]
      public string gxTpr_Sys_usercreatetime_Z_Nullable
      {
         get {
            if ( gxTv_SdtSYS_User_Sys_usercreatetime_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtSYS_User_Sys_usercreatetime_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtSYS_User_Sys_usercreatetime_Z = DateTime.MinValue;
            else
               gxTv_SdtSYS_User_Sys_usercreatetime_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Sys_usercreatetime_Z
      {
         get {
            return gxTv_SdtSYS_User_Sys_usercreatetime_Z ;
         }

         set {
            gxTv_SdtSYS_User_Sys_usercreatetime_Z = value;
            SetDirty("Sys_usercreatetime_Z");
         }

      }

      public void gxTv_SdtSYS_User_Sys_usercreatetime_Z_SetNull( )
      {
         gxTv_SdtSYS_User_Sys_usercreatetime_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtSYS_User_Sys_usercreatetime_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_UserModifier_Z" )]
      [  XmlElement( ElementName = "SYS_UserModifier_Z"   )]
      public String gxTpr_Sys_usermodifier_Z
      {
         get {
            return gxTv_SdtSYS_User_Sys_usermodifier_Z ;
         }

         set {
            gxTv_SdtSYS_User_Sys_usermodifier_Z = value;
            SetDirty("Sys_usermodifier_Z");
         }

      }

      public void gxTv_SdtSYS_User_Sys_usermodifier_Z_SetNull( )
      {
         gxTv_SdtSYS_User_Sys_usermodifier_Z = "";
         return  ;
      }

      public bool gxTv_SdtSYS_User_Sys_usermodifier_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_UserModifyTime_Z" )]
      [  XmlElement( ElementName = "SYS_UserModifyTime_Z"  , IsNullable=true )]
      public string gxTpr_Sys_usermodifytime_Z_Nullable
      {
         get {
            if ( gxTv_SdtSYS_User_Sys_usermodifytime_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtSYS_User_Sys_usermodifytime_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtSYS_User_Sys_usermodifytime_Z = DateTime.MinValue;
            else
               gxTv_SdtSYS_User_Sys_usermodifytime_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Sys_usermodifytime_Z
      {
         get {
            return gxTv_SdtSYS_User_Sys_usermodifytime_Z ;
         }

         set {
            gxTv_SdtSYS_User_Sys_usermodifytime_Z = value;
            SetDirty("Sys_usermodifytime_Z");
         }

      }

      public void gxTv_SdtSYS_User_Sys_usermodifytime_Z_SetNull( )
      {
         gxTv_SdtSYS_User_Sys_usermodifytime_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtSYS_User_Sys_usermodifytime_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_UserIsDeleted_Z" )]
      [  XmlElement( ElementName = "SYS_UserIsDeleted_Z"   )]
      public short gxTpr_Sys_userisdeleted_Z
      {
         get {
            return gxTv_SdtSYS_User_Sys_userisdeleted_Z ;
         }

         set {
            gxTv_SdtSYS_User_Sys_userisdeleted_Z = value;
            SetDirty("Sys_userisdeleted_Z");
         }

      }

      public void gxTv_SdtSYS_User_Sys_userisdeleted_Z_SetNull( )
      {
         gxTv_SdtSYS_User_Sys_userisdeleted_Z = 0;
         return  ;
      }

      public bool gxTv_SdtSYS_User_Sys_userisdeleted_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Email_Z" )]
      [  XmlElement( ElementName = "Email_Z"   )]
      public String gxTpr_Email_Z
      {
         get {
            return gxTv_SdtSYS_User_Email_Z ;
         }

         set {
            gxTv_SdtSYS_User_Email_Z = value;
            SetDirty("Email_Z");
         }

      }

      public void gxTv_SdtSYS_User_Email_Z_SetNull( )
      {
         gxTv_SdtSYS_User_Email_Z = "";
         return  ;
      }

      public bool gxTv_SdtSYS_User_Email_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "RocheAccount_Z" )]
      [  XmlElement( ElementName = "RocheAccount_Z"   )]
      public String gxTpr_Rocheaccount_Z
      {
         get {
            return gxTv_SdtSYS_User_Rocheaccount_Z ;
         }

         set {
            gxTv_SdtSYS_User_Rocheaccount_Z = value;
            SetDirty("Rocheaccount_Z");
         }

      }

      public void gxTv_SdtSYS_User_Rocheaccount_Z_SetNull( )
      {
         gxTv_SdtSYS_User_Rocheaccount_Z = "";
         return  ;
      }

      public bool gxTv_SdtSYS_User_Rocheaccount_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "LoginIP_N" )]
      [  XmlElement( ElementName = "LoginIP_N"   )]
      public short gxTpr_Loginip_N
      {
         get {
            return gxTv_SdtSYS_User_Loginip_N ;
         }

         set {
            gxTv_SdtSYS_User_Loginip_N = value;
            SetDirty("Loginip_N");
         }

      }

      public void gxTv_SdtSYS_User_Loginip_N_SetNull( )
      {
         gxTv_SdtSYS_User_Loginip_N = 0;
         return  ;
      }

      public bool gxTv_SdtSYS_User_Loginip_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "LoginTime_N" )]
      [  XmlElement( ElementName = "LoginTime_N"   )]
      public short gxTpr_Logintime_N
      {
         get {
            return gxTv_SdtSYS_User_Logintime_N ;
         }

         set {
            gxTv_SdtSYS_User_Logintime_N = value;
            SetDirty("Logintime_N");
         }

      }

      public void gxTv_SdtSYS_User_Logintime_N_SetNull( )
      {
         gxTv_SdtSYS_User_Logintime_N = 0;
         return  ;
      }

      public bool gxTv_SdtSYS_User_Logintime_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_UserModifier_N" )]
      [  XmlElement( ElementName = "SYS_UserModifier_N"   )]
      public short gxTpr_Sys_usermodifier_N
      {
         get {
            return gxTv_SdtSYS_User_Sys_usermodifier_N ;
         }

         set {
            gxTv_SdtSYS_User_Sys_usermodifier_N = value;
            SetDirty("Sys_usermodifier_N");
         }

      }

      public void gxTv_SdtSYS_User_Sys_usermodifier_N_SetNull( )
      {
         gxTv_SdtSYS_User_Sys_usermodifier_N = 0;
         return  ;
      }

      public bool gxTv_SdtSYS_User_Sys_usermodifier_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_UserModifyTime_N" )]
      [  XmlElement( ElementName = "SYS_UserModifyTime_N"   )]
      public short gxTpr_Sys_usermodifytime_N
      {
         get {
            return gxTv_SdtSYS_User_Sys_usermodifytime_N ;
         }

         set {
            gxTv_SdtSYS_User_Sys_usermodifytime_N = value;
            SetDirty("Sys_usermodifytime_N");
         }

      }

      public void gxTv_SdtSYS_User_Sys_usermodifytime_N_SetNull( )
      {
         gxTv_SdtSYS_User_Sys_usermodifytime_N = 0;
         return  ;
      }

      public bool gxTv_SdtSYS_User_Sys_usermodifytime_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Email_N" )]
      [  XmlElement( ElementName = "Email_N"   )]
      public short gxTpr_Email_N
      {
         get {
            return gxTv_SdtSYS_User_Email_N ;
         }

         set {
            gxTv_SdtSYS_User_Email_N = value;
            SetDirty("Email_N");
         }

      }

      public void gxTv_SdtSYS_User_Email_N_SetNull( )
      {
         gxTv_SdtSYS_User_Email_N = 0;
         return  ;
      }

      public bool gxTv_SdtSYS_User_Email_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_UserDescription_N" )]
      [  XmlElement( ElementName = "SYS_UserDescription_N"   )]
      public short gxTpr_Sys_userdescription_N
      {
         get {
            return gxTv_SdtSYS_User_Sys_userdescription_N ;
         }

         set {
            gxTv_SdtSYS_User_Sys_userdescription_N = value;
            SetDirty("Sys_userdescription_N");
         }

      }

      public void gxTv_SdtSYS_User_Sys_userdescription_N_SetNull( )
      {
         gxTv_SdtSYS_User_Sys_userdescription_N = 0;
         return  ;
      }

      public bool gxTv_SdtSYS_User_Sys_userdescription_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "RocheAccount_N" )]
      [  XmlElement( ElementName = "RocheAccount_N"   )]
      public short gxTpr_Rocheaccount_N
      {
         get {
            return gxTv_SdtSYS_User_Rocheaccount_N ;
         }

         set {
            gxTv_SdtSYS_User_Rocheaccount_N = value;
            SetDirty("Rocheaccount_N");
         }

      }

      public void gxTv_SdtSYS_User_Rocheaccount_N_SetNull( )
      {
         gxTv_SdtSYS_User_Rocheaccount_N = 0;
         return  ;
      }

      public bool gxTv_SdtSYS_User_Rocheaccount_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtSYS_User_Userid = (Guid)(Guid.Empty);
         gxTv_SdtSYS_User_Displayname = "";
         gxTv_SdtSYS_User_Account = "";
         gxTv_SdtSYS_User_Passwordhash = "";
         gxTv_SdtSYS_User_Loginip = "";
         gxTv_SdtSYS_User_Logintime = (DateTime)(DateTime.MinValue);
         gxTv_SdtSYS_User_Sys_usercreator = "";
         gxTv_SdtSYS_User_Sys_usercreatetime = (DateTime)(DateTime.MinValue);
         gxTv_SdtSYS_User_Sys_usermodifier = "";
         gxTv_SdtSYS_User_Sys_usermodifytime = (DateTime)(DateTime.MinValue);
         gxTv_SdtSYS_User_Email = "";
         gxTv_SdtSYS_User_Sys_userdescription = "";
         gxTv_SdtSYS_User_Rocheaccount = "";
         gxTv_SdtSYS_User_Mode = "";
         gxTv_SdtSYS_User_Userid_Z = (Guid)(Guid.Empty);
         gxTv_SdtSYS_User_Displayname_Z = "";
         gxTv_SdtSYS_User_Account_Z = "";
         gxTv_SdtSYS_User_Passwordhash_Z = "";
         gxTv_SdtSYS_User_Loginip_Z = "";
         gxTv_SdtSYS_User_Logintime_Z = (DateTime)(DateTime.MinValue);
         gxTv_SdtSYS_User_Sys_usercreator_Z = "";
         gxTv_SdtSYS_User_Sys_usercreatetime_Z = (DateTime)(DateTime.MinValue);
         gxTv_SdtSYS_User_Sys_usermodifier_Z = "";
         gxTv_SdtSYS_User_Sys_usermodifytime_Z = (DateTime)(DateTime.MinValue);
         gxTv_SdtSYS_User_Email_Z = "";
         gxTv_SdtSYS_User_Rocheaccount_Z = "";
         datetime_STZ = (DateTime)(DateTime.MinValue);
         sDateCnv = "";
         sNumToPad = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "sys_user", "GeneXus.Programs.sys_user_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtSYS_User_Sys_userisdeleted ;
      private short gxTv_SdtSYS_User_Initialized ;
      private short gxTv_SdtSYS_User_Sys_userisdeleted_Z ;
      private short gxTv_SdtSYS_User_Loginip_N ;
      private short gxTv_SdtSYS_User_Logintime_N ;
      private short gxTv_SdtSYS_User_Sys_usermodifier_N ;
      private short gxTv_SdtSYS_User_Sys_usermodifytime_N ;
      private short gxTv_SdtSYS_User_Email_N ;
      private short gxTv_SdtSYS_User_Sys_userdescription_N ;
      private short gxTv_SdtSYS_User_Rocheaccount_N ;
      private int gxTv_SdtSYS_User_Usertype ;
      private int gxTv_SdtSYS_User_Usertype_Z ;
      private String gxTv_SdtSYS_User_Mode ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_SdtSYS_User_Logintime ;
      private DateTime gxTv_SdtSYS_User_Sys_usercreatetime ;
      private DateTime gxTv_SdtSYS_User_Sys_usermodifytime ;
      private DateTime gxTv_SdtSYS_User_Logintime_Z ;
      private DateTime gxTv_SdtSYS_User_Sys_usercreatetime_Z ;
      private DateTime gxTv_SdtSYS_User_Sys_usermodifytime_Z ;
      private DateTime datetime_STZ ;
      private String gxTv_SdtSYS_User_Sys_userdescription ;
      private String gxTv_SdtSYS_User_Displayname ;
      private String gxTv_SdtSYS_User_Account ;
      private String gxTv_SdtSYS_User_Passwordhash ;
      private String gxTv_SdtSYS_User_Loginip ;
      private String gxTv_SdtSYS_User_Sys_usercreator ;
      private String gxTv_SdtSYS_User_Sys_usermodifier ;
      private String gxTv_SdtSYS_User_Email ;
      private String gxTv_SdtSYS_User_Rocheaccount ;
      private String gxTv_SdtSYS_User_Displayname_Z ;
      private String gxTv_SdtSYS_User_Account_Z ;
      private String gxTv_SdtSYS_User_Passwordhash_Z ;
      private String gxTv_SdtSYS_User_Loginip_Z ;
      private String gxTv_SdtSYS_User_Sys_usercreator_Z ;
      private String gxTv_SdtSYS_User_Sys_usermodifier_Z ;
      private String gxTv_SdtSYS_User_Email_Z ;
      private String gxTv_SdtSYS_User_Rocheaccount_Z ;
      private Guid gxTv_SdtSYS_User_Userid ;
      private Guid gxTv_SdtSYS_User_Userid_Z ;
   }

   [DataContract(Name = @"SYS_User", Namespace = "DataAnalysisPlatform")]
   public class SdtSYS_User_RESTInterface : GxGenericCollectionItem<SdtSYS_User>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSYS_User_RESTInterface( ) : base()
      {
      }

      public SdtSYS_User_RESTInterface( SdtSYS_User psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "UserID" , Order = 0 )]
      [GxSeudo()]
      public Guid gxTpr_Userid
      {
         get {
            return sdt.gxTpr_Userid ;
         }

         set {
            sdt.gxTpr_Userid = (Guid)(value);
         }

      }

      [DataMember( Name = "DisplayName" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Displayname
      {
         get {
            return sdt.gxTpr_Displayname ;
         }

         set {
            sdt.gxTpr_Displayname = value;
         }

      }

      [DataMember( Name = "UserType" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Usertype
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Usertype), 9, 0)) ;
         }

         set {
            sdt.gxTpr_Usertype = (int)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "Account" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Account
      {
         get {
            return sdt.gxTpr_Account ;
         }

         set {
            sdt.gxTpr_Account = value;
         }

      }

      [DataMember( Name = "PasswordHash" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Passwordhash
      {
         get {
            return sdt.gxTpr_Passwordhash ;
         }

         set {
            sdt.gxTpr_Passwordhash = value;
         }

      }

      [DataMember( Name = "LoginIP" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Loginip
      {
         get {
            return sdt.gxTpr_Loginip ;
         }

         set {
            sdt.gxTpr_Loginip = value;
         }

      }

      [DataMember( Name = "LoginTime" , Order = 6 )]
      [GxSeudo()]
      public String gxTpr_Logintime
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Logintime) ;
         }

         set {
            sdt.gxTpr_Logintime = DateTimeUtil.CToT2( value);
         }

      }

      [DataMember( Name = "SYS_UserCreator" , Order = 7 )]
      [GxSeudo()]
      public String gxTpr_Sys_usercreator
      {
         get {
            return sdt.gxTpr_Sys_usercreator ;
         }

         set {
            sdt.gxTpr_Sys_usercreator = value;
         }

      }

      [DataMember( Name = "SYS_UserCreateTime" , Order = 8 )]
      [GxSeudo()]
      public String gxTpr_Sys_usercreatetime
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Sys_usercreatetime) ;
         }

         set {
            sdt.gxTpr_Sys_usercreatetime = DateTimeUtil.CToT2( value);
         }

      }

      [DataMember( Name = "SYS_UserModifier" , Order = 9 )]
      [GxSeudo()]
      public String gxTpr_Sys_usermodifier
      {
         get {
            return sdt.gxTpr_Sys_usermodifier ;
         }

         set {
            sdt.gxTpr_Sys_usermodifier = value;
         }

      }

      [DataMember( Name = "SYS_UserModifyTime" , Order = 10 )]
      [GxSeudo()]
      public String gxTpr_Sys_usermodifytime
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Sys_usermodifytime) ;
         }

         set {
            sdt.gxTpr_Sys_usermodifytime = DateTimeUtil.CToT2( value);
         }

      }

      [DataMember( Name = "SYS_UserIsDeleted" , Order = 11 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Sys_userisdeleted
      {
         get {
            return sdt.gxTpr_Sys_userisdeleted ;
         }

         set {
            sdt.gxTpr_Sys_userisdeleted = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "Email" , Order = 12 )]
      [GxSeudo()]
      public String gxTpr_Email
      {
         get {
            return sdt.gxTpr_Email ;
         }

         set {
            sdt.gxTpr_Email = value;
         }

      }

      [DataMember( Name = "SYS_UserDescription" , Order = 13 )]
      public String gxTpr_Sys_userdescription
      {
         get {
            return sdt.gxTpr_Sys_userdescription ;
         }

         set {
            sdt.gxTpr_Sys_userdescription = value;
         }

      }

      [DataMember( Name = "RocheAccount" , Order = 14 )]
      [GxSeudo()]
      public String gxTpr_Rocheaccount
      {
         get {
            return sdt.gxTpr_Rocheaccount ;
         }

         set {
            sdt.gxTpr_Rocheaccount = value;
         }

      }

      public SdtSYS_User sdt
      {
         get {
            return (SdtSYS_User)Sdt ;
         }

         set {
            Sdt = value ;
         }

      }

      [OnDeserializing]
      void checkSdt( StreamingContext ctx )
      {
         if ( sdt == null )
         {
            sdt = new SdtSYS_User() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 15 )]
      public string Hash
      {
         get {
            if ( StringUtil.StrCmp(md5Hash, null) == 0 )
            {
               md5Hash = (String)(getHash());
            }
            return md5Hash ;
         }

         set {
            md5Hash = value ;
         }

      }

      private String md5Hash ;
   }

}

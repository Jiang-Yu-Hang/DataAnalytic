/*
               File: wwpbaseobjects.type_SdtSecUser
        Description: 账号
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:55:33.59
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
namespace GeneXus.Programs.wwpbaseobjects {
   [XmlSerializerFormat]
   [XmlRoot(ElementName = "SecUser" )]
   [XmlType(TypeName =  "SecUser" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtSecUser : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSecUser( )
      {
      }

      public SdtSecUser( IGxContext context )
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

      public void Load( short AV6SecUserId )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(short)AV6SecUserId});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"SecUserId", typeof(short)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "WWPBaseObjects\\SecUser");
         metadata.Set("BT", "SecUser");
         metadata.Set("PK", "[ \"SecUserId\" ]");
         metadata.Set("PKAssigned", "[ \"SecUserId\" ]");
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
         state.Add("gxTpr_Secuserid_Z");
         state.Add("gxTpr_Secusername_Z");
         state.Add("gxTpr_Secuserpassword_Z");
         state.Add("gxTpr_Secusercrtuser_Z");
         state.Add("gxTpr_Secuserupduser_Z");
         state.Add("gxTpr_Secusercrtdate_Z_Nullable");
         state.Add("gxTpr_Secuserupddate_Z_Nullable");
         state.Add("gxTpr_Secuserworkload_Z");
         state.Add("gxTpr_Secusercrtuser_N");
         state.Add("gxTpr_Secuserupduser_N");
         state.Add("gxTpr_Secusercrtdate_N");
         state.Add("gxTpr_Secuserupddate_N");
         state.Add("gxTpr_Secuserworkload_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         GeneXus.Programs.wwpbaseobjects.SdtSecUser sdt ;
         sdt = (GeneXus.Programs.wwpbaseobjects.SdtSecUser)(source);
         gxTv_SdtSecUser_Secuserid = sdt.gxTv_SdtSecUser_Secuserid ;
         gxTv_SdtSecUser_Secusername = sdt.gxTv_SdtSecUser_Secusername ;
         gxTv_SdtSecUser_Secuserpassword = sdt.gxTv_SdtSecUser_Secuserpassword ;
         gxTv_SdtSecUser_Secusercrtuser = sdt.gxTv_SdtSecUser_Secusercrtuser ;
         gxTv_SdtSecUser_Secuserupduser = sdt.gxTv_SdtSecUser_Secuserupduser ;
         gxTv_SdtSecUser_Secusercrtdate = sdt.gxTv_SdtSecUser_Secusercrtdate ;
         gxTv_SdtSecUser_Secuserupddate = sdt.gxTv_SdtSecUser_Secuserupddate ;
         gxTv_SdtSecUser_Secuserworkload = sdt.gxTv_SdtSecUser_Secuserworkload ;
         gxTv_SdtSecUser_Mode = sdt.gxTv_SdtSecUser_Mode ;
         gxTv_SdtSecUser_Initialized = sdt.gxTv_SdtSecUser_Initialized ;
         gxTv_SdtSecUser_Secuserid_Z = sdt.gxTv_SdtSecUser_Secuserid_Z ;
         gxTv_SdtSecUser_Secusername_Z = sdt.gxTv_SdtSecUser_Secusername_Z ;
         gxTv_SdtSecUser_Secuserpassword_Z = sdt.gxTv_SdtSecUser_Secuserpassword_Z ;
         gxTv_SdtSecUser_Secusercrtuser_Z = sdt.gxTv_SdtSecUser_Secusercrtuser_Z ;
         gxTv_SdtSecUser_Secuserupduser_Z = sdt.gxTv_SdtSecUser_Secuserupduser_Z ;
         gxTv_SdtSecUser_Secusercrtdate_Z = sdt.gxTv_SdtSecUser_Secusercrtdate_Z ;
         gxTv_SdtSecUser_Secuserupddate_Z = sdt.gxTv_SdtSecUser_Secuserupddate_Z ;
         gxTv_SdtSecUser_Secuserworkload_Z = sdt.gxTv_SdtSecUser_Secuserworkload_Z ;
         gxTv_SdtSecUser_Secusercrtuser_N = sdt.gxTv_SdtSecUser_Secusercrtuser_N ;
         gxTv_SdtSecUser_Secuserupduser_N = sdt.gxTv_SdtSecUser_Secuserupduser_N ;
         gxTv_SdtSecUser_Secusercrtdate_N = sdt.gxTv_SdtSecUser_Secusercrtdate_N ;
         gxTv_SdtSecUser_Secuserupddate_N = sdt.gxTv_SdtSecUser_Secuserupddate_N ;
         gxTv_SdtSecUser_Secuserworkload_N = sdt.gxTv_SdtSecUser_Secuserworkload_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("SecUserId", gxTv_SdtSecUser_Secuserid, false);
         AddObjectProperty("SecUserName", gxTv_SdtSecUser_Secusername, false);
         AddObjectProperty("SecUserPassword", gxTv_SdtSecUser_Secuserpassword, false);
         AddObjectProperty("SecUserCrtUser", gxTv_SdtSecUser_Secusercrtuser, false);
         AddObjectProperty("SecUserCrtUser_N", gxTv_SdtSecUser_Secusercrtuser_N, false);
         AddObjectProperty("SecUserUpdUser", gxTv_SdtSecUser_Secuserupduser, false);
         AddObjectProperty("SecUserUpdUser_N", gxTv_SdtSecUser_Secuserupduser_N, false);
         datetime_STZ = gxTv_SdtSecUser_Secusercrtdate;
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
         AddObjectProperty("SecUserCrtDate", sDateCnv, false);
         AddObjectProperty("SecUserCrtDate_N", gxTv_SdtSecUser_Secusercrtdate_N, false);
         datetime_STZ = gxTv_SdtSecUser_Secuserupddate;
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
         AddObjectProperty("SecUserUpdDate", sDateCnv, false);
         AddObjectProperty("SecUserUpdDate_N", gxTv_SdtSecUser_Secuserupddate_N, false);
         AddObjectProperty("SecUserWorkload", gxTv_SdtSecUser_Secuserworkload, false);
         AddObjectProperty("SecUserWorkload_N", gxTv_SdtSecUser_Secuserworkload_N, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtSecUser_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtSecUser_Initialized, false);
            AddObjectProperty("SecUserId_Z", gxTv_SdtSecUser_Secuserid_Z, false);
            AddObjectProperty("SecUserName_Z", gxTv_SdtSecUser_Secusername_Z, false);
            AddObjectProperty("SecUserPassword_Z", gxTv_SdtSecUser_Secuserpassword_Z, false);
            AddObjectProperty("SecUserCrtUser_Z", gxTv_SdtSecUser_Secusercrtuser_Z, false);
            AddObjectProperty("SecUserUpdUser_Z", gxTv_SdtSecUser_Secuserupduser_Z, false);
            datetime_STZ = gxTv_SdtSecUser_Secusercrtdate_Z;
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
            AddObjectProperty("SecUserCrtDate_Z", sDateCnv, false);
            datetime_STZ = gxTv_SdtSecUser_Secuserupddate_Z;
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
            AddObjectProperty("SecUserUpdDate_Z", sDateCnv, false);
            AddObjectProperty("SecUserWorkload_Z", gxTv_SdtSecUser_Secuserworkload_Z, false);
            AddObjectProperty("SecUserCrtUser_N", gxTv_SdtSecUser_Secusercrtuser_N, false);
            AddObjectProperty("SecUserUpdUser_N", gxTv_SdtSecUser_Secuserupduser_N, false);
            AddObjectProperty("SecUserCrtDate_N", gxTv_SdtSecUser_Secusercrtdate_N, false);
            AddObjectProperty("SecUserUpdDate_N", gxTv_SdtSecUser_Secuserupddate_N, false);
            AddObjectProperty("SecUserWorkload_N", gxTv_SdtSecUser_Secuserworkload_N, false);
         }
         return  ;
      }

      public void UpdateDirties( GeneXus.Programs.wwpbaseobjects.SdtSecUser sdt )
      {
         if ( sdt.IsDirty("SecUserId") )
         {
            gxTv_SdtSecUser_Secuserid = sdt.gxTv_SdtSecUser_Secuserid ;
         }
         if ( sdt.IsDirty("SecUserName") )
         {
            gxTv_SdtSecUser_Secusername = sdt.gxTv_SdtSecUser_Secusername ;
         }
         if ( sdt.IsDirty("SecUserPassword") )
         {
            gxTv_SdtSecUser_Secuserpassword = sdt.gxTv_SdtSecUser_Secuserpassword ;
         }
         if ( sdt.IsDirty("SecUserCrtUser") )
         {
            gxTv_SdtSecUser_Secusercrtuser = sdt.gxTv_SdtSecUser_Secusercrtuser ;
         }
         if ( sdt.IsDirty("SecUserUpdUser") )
         {
            gxTv_SdtSecUser_Secuserupduser = sdt.gxTv_SdtSecUser_Secuserupduser ;
         }
         if ( sdt.IsDirty("SecUserCrtDate") )
         {
            gxTv_SdtSecUser_Secusercrtdate = sdt.gxTv_SdtSecUser_Secusercrtdate ;
         }
         if ( sdt.IsDirty("SecUserUpdDate") )
         {
            gxTv_SdtSecUser_Secuserupddate = sdt.gxTv_SdtSecUser_Secuserupddate ;
         }
         if ( sdt.IsDirty("SecUserWorkload") )
         {
            gxTv_SdtSecUser_Secuserworkload = sdt.gxTv_SdtSecUser_Secuserworkload ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "SecUserId" )]
      [  XmlElement( ElementName = "SecUserId"   )]
      public short gxTpr_Secuserid
      {
         get {
            return gxTv_SdtSecUser_Secuserid ;
         }

         set {
            if ( gxTv_SdtSecUser_Secuserid != value )
            {
               gxTv_SdtSecUser_Mode = "INS";
               this.gxTv_SdtSecUser_Secuserid_Z_SetNull( );
               this.gxTv_SdtSecUser_Secusername_Z_SetNull( );
               this.gxTv_SdtSecUser_Secuserpassword_Z_SetNull( );
               this.gxTv_SdtSecUser_Secusercrtuser_Z_SetNull( );
               this.gxTv_SdtSecUser_Secuserupduser_Z_SetNull( );
               this.gxTv_SdtSecUser_Secusercrtdate_Z_SetNull( );
               this.gxTv_SdtSecUser_Secuserupddate_Z_SetNull( );
               this.gxTv_SdtSecUser_Secuserworkload_Z_SetNull( );
            }
            gxTv_SdtSecUser_Secuserid = value;
            SetDirty("Secuserid");
         }

      }

      [  SoapElement( ElementName = "SecUserName" )]
      [  XmlElement( ElementName = "SecUserName"   )]
      public String gxTpr_Secusername
      {
         get {
            return gxTv_SdtSecUser_Secusername ;
         }

         set {
            gxTv_SdtSecUser_Secusername = value;
            SetDirty("Secusername");
         }

      }

      [  SoapElement( ElementName = "SecUserPassword" )]
      [  XmlElement( ElementName = "SecUserPassword"   )]
      public String gxTpr_Secuserpassword
      {
         get {
            return gxTv_SdtSecUser_Secuserpassword ;
         }

         set {
            gxTv_SdtSecUser_Secuserpassword = value;
            SetDirty("Secuserpassword");
         }

      }

      [  SoapElement( ElementName = "SecUserCrtUser" )]
      [  XmlElement( ElementName = "SecUserCrtUser"   )]
      public String gxTpr_Secusercrtuser
      {
         get {
            return gxTv_SdtSecUser_Secusercrtuser ;
         }

         set {
            gxTv_SdtSecUser_Secusercrtuser_N = 0;
            gxTv_SdtSecUser_Secusercrtuser = value;
            SetDirty("Secusercrtuser");
         }

      }

      public void gxTv_SdtSecUser_Secusercrtuser_SetNull( )
      {
         gxTv_SdtSecUser_Secusercrtuser_N = 1;
         gxTv_SdtSecUser_Secusercrtuser = "";
         return  ;
      }

      public bool gxTv_SdtSecUser_Secusercrtuser_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SecUserUpdUser" )]
      [  XmlElement( ElementName = "SecUserUpdUser"   )]
      public String gxTpr_Secuserupduser
      {
         get {
            return gxTv_SdtSecUser_Secuserupduser ;
         }

         set {
            gxTv_SdtSecUser_Secuserupduser_N = 0;
            gxTv_SdtSecUser_Secuserupduser = value;
            SetDirty("Secuserupduser");
         }

      }

      public void gxTv_SdtSecUser_Secuserupduser_SetNull( )
      {
         gxTv_SdtSecUser_Secuserupduser_N = 1;
         gxTv_SdtSecUser_Secuserupduser = "";
         return  ;
      }

      public bool gxTv_SdtSecUser_Secuserupduser_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SecUserCrtDate" )]
      [  XmlElement( ElementName = "SecUserCrtDate"  , IsNullable=true )]
      public string gxTpr_Secusercrtdate_Nullable
      {
         get {
            if ( gxTv_SdtSecUser_Secusercrtdate == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtSecUser_Secusercrtdate).value ;
         }

         set {
            gxTv_SdtSecUser_Secusercrtdate_N = 0;
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtSecUser_Secusercrtdate = DateTime.MinValue;
            else
               gxTv_SdtSecUser_Secusercrtdate = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Secusercrtdate
      {
         get {
            return gxTv_SdtSecUser_Secusercrtdate ;
         }

         set {
            gxTv_SdtSecUser_Secusercrtdate_N = 0;
            gxTv_SdtSecUser_Secusercrtdate = value;
            SetDirty("Secusercrtdate");
         }

      }

      public void gxTv_SdtSecUser_Secusercrtdate_SetNull( )
      {
         gxTv_SdtSecUser_Secusercrtdate_N = 1;
         gxTv_SdtSecUser_Secusercrtdate = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtSecUser_Secusercrtdate_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SecUserUpdDate" )]
      [  XmlElement( ElementName = "SecUserUpdDate"  , IsNullable=true )]
      public string gxTpr_Secuserupddate_Nullable
      {
         get {
            if ( gxTv_SdtSecUser_Secuserupddate == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtSecUser_Secuserupddate).value ;
         }

         set {
            gxTv_SdtSecUser_Secuserupddate_N = 0;
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtSecUser_Secuserupddate = DateTime.MinValue;
            else
               gxTv_SdtSecUser_Secuserupddate = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Secuserupddate
      {
         get {
            return gxTv_SdtSecUser_Secuserupddate ;
         }

         set {
            gxTv_SdtSecUser_Secuserupddate_N = 0;
            gxTv_SdtSecUser_Secuserupddate = value;
            SetDirty("Secuserupddate");
         }

      }

      public void gxTv_SdtSecUser_Secuserupddate_SetNull( )
      {
         gxTv_SdtSecUser_Secuserupddate_N = 1;
         gxTv_SdtSecUser_Secuserupddate = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtSecUser_Secuserupddate_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SecUserWorkload" )]
      [  XmlElement( ElementName = "SecUserWorkload"   )]
      public long gxTpr_Secuserworkload
      {
         get {
            return gxTv_SdtSecUser_Secuserworkload ;
         }

         set {
            gxTv_SdtSecUser_Secuserworkload_N = 0;
            gxTv_SdtSecUser_Secuserworkload = value;
            SetDirty("Secuserworkload");
         }

      }

      public void gxTv_SdtSecUser_Secuserworkload_SetNull( )
      {
         gxTv_SdtSecUser_Secuserworkload_N = 1;
         gxTv_SdtSecUser_Secuserworkload = 0;
         return  ;
      }

      public bool gxTv_SdtSecUser_Secuserworkload_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtSecUser_Mode ;
         }

         set {
            gxTv_SdtSecUser_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtSecUser_Mode_SetNull( )
      {
         gxTv_SdtSecUser_Mode = "";
         return  ;
      }

      public bool gxTv_SdtSecUser_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtSecUser_Initialized ;
         }

         set {
            gxTv_SdtSecUser_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtSecUser_Initialized_SetNull( )
      {
         gxTv_SdtSecUser_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtSecUser_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SecUserId_Z" )]
      [  XmlElement( ElementName = "SecUserId_Z"   )]
      public short gxTpr_Secuserid_Z
      {
         get {
            return gxTv_SdtSecUser_Secuserid_Z ;
         }

         set {
            gxTv_SdtSecUser_Secuserid_Z = value;
            SetDirty("Secuserid_Z");
         }

      }

      public void gxTv_SdtSecUser_Secuserid_Z_SetNull( )
      {
         gxTv_SdtSecUser_Secuserid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtSecUser_Secuserid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SecUserName_Z" )]
      [  XmlElement( ElementName = "SecUserName_Z"   )]
      public String gxTpr_Secusername_Z
      {
         get {
            return gxTv_SdtSecUser_Secusername_Z ;
         }

         set {
            gxTv_SdtSecUser_Secusername_Z = value;
            SetDirty("Secusername_Z");
         }

      }

      public void gxTv_SdtSecUser_Secusername_Z_SetNull( )
      {
         gxTv_SdtSecUser_Secusername_Z = "";
         return  ;
      }

      public bool gxTv_SdtSecUser_Secusername_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SecUserPassword_Z" )]
      [  XmlElement( ElementName = "SecUserPassword_Z"   )]
      public String gxTpr_Secuserpassword_Z
      {
         get {
            return gxTv_SdtSecUser_Secuserpassword_Z ;
         }

         set {
            gxTv_SdtSecUser_Secuserpassword_Z = value;
            SetDirty("Secuserpassword_Z");
         }

      }

      public void gxTv_SdtSecUser_Secuserpassword_Z_SetNull( )
      {
         gxTv_SdtSecUser_Secuserpassword_Z = "";
         return  ;
      }

      public bool gxTv_SdtSecUser_Secuserpassword_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SecUserCrtUser_Z" )]
      [  XmlElement( ElementName = "SecUserCrtUser_Z"   )]
      public String gxTpr_Secusercrtuser_Z
      {
         get {
            return gxTv_SdtSecUser_Secusercrtuser_Z ;
         }

         set {
            gxTv_SdtSecUser_Secusercrtuser_Z = value;
            SetDirty("Secusercrtuser_Z");
         }

      }

      public void gxTv_SdtSecUser_Secusercrtuser_Z_SetNull( )
      {
         gxTv_SdtSecUser_Secusercrtuser_Z = "";
         return  ;
      }

      public bool gxTv_SdtSecUser_Secusercrtuser_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SecUserUpdUser_Z" )]
      [  XmlElement( ElementName = "SecUserUpdUser_Z"   )]
      public String gxTpr_Secuserupduser_Z
      {
         get {
            return gxTv_SdtSecUser_Secuserupduser_Z ;
         }

         set {
            gxTv_SdtSecUser_Secuserupduser_Z = value;
            SetDirty("Secuserupduser_Z");
         }

      }

      public void gxTv_SdtSecUser_Secuserupduser_Z_SetNull( )
      {
         gxTv_SdtSecUser_Secuserupduser_Z = "";
         return  ;
      }

      public bool gxTv_SdtSecUser_Secuserupduser_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SecUserCrtDate_Z" )]
      [  XmlElement( ElementName = "SecUserCrtDate_Z"  , IsNullable=true )]
      public string gxTpr_Secusercrtdate_Z_Nullable
      {
         get {
            if ( gxTv_SdtSecUser_Secusercrtdate_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtSecUser_Secusercrtdate_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtSecUser_Secusercrtdate_Z = DateTime.MinValue;
            else
               gxTv_SdtSecUser_Secusercrtdate_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Secusercrtdate_Z
      {
         get {
            return gxTv_SdtSecUser_Secusercrtdate_Z ;
         }

         set {
            gxTv_SdtSecUser_Secusercrtdate_Z = value;
            SetDirty("Secusercrtdate_Z");
         }

      }

      public void gxTv_SdtSecUser_Secusercrtdate_Z_SetNull( )
      {
         gxTv_SdtSecUser_Secusercrtdate_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtSecUser_Secusercrtdate_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SecUserUpdDate_Z" )]
      [  XmlElement( ElementName = "SecUserUpdDate_Z"  , IsNullable=true )]
      public string gxTpr_Secuserupddate_Z_Nullable
      {
         get {
            if ( gxTv_SdtSecUser_Secuserupddate_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtSecUser_Secuserupddate_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtSecUser_Secuserupddate_Z = DateTime.MinValue;
            else
               gxTv_SdtSecUser_Secuserupddate_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Secuserupddate_Z
      {
         get {
            return gxTv_SdtSecUser_Secuserupddate_Z ;
         }

         set {
            gxTv_SdtSecUser_Secuserupddate_Z = value;
            SetDirty("Secuserupddate_Z");
         }

      }

      public void gxTv_SdtSecUser_Secuserupddate_Z_SetNull( )
      {
         gxTv_SdtSecUser_Secuserupddate_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtSecUser_Secuserupddate_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SecUserWorkload_Z" )]
      [  XmlElement( ElementName = "SecUserWorkload_Z"   )]
      public long gxTpr_Secuserworkload_Z
      {
         get {
            return gxTv_SdtSecUser_Secuserworkload_Z ;
         }

         set {
            gxTv_SdtSecUser_Secuserworkload_Z = value;
            SetDirty("Secuserworkload_Z");
         }

      }

      public void gxTv_SdtSecUser_Secuserworkload_Z_SetNull( )
      {
         gxTv_SdtSecUser_Secuserworkload_Z = 0;
         return  ;
      }

      public bool gxTv_SdtSecUser_Secuserworkload_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SecUserCrtUser_N" )]
      [  XmlElement( ElementName = "SecUserCrtUser_N"   )]
      public short gxTpr_Secusercrtuser_N
      {
         get {
            return gxTv_SdtSecUser_Secusercrtuser_N ;
         }

         set {
            gxTv_SdtSecUser_Secusercrtuser_N = value;
            SetDirty("Secusercrtuser_N");
         }

      }

      public void gxTv_SdtSecUser_Secusercrtuser_N_SetNull( )
      {
         gxTv_SdtSecUser_Secusercrtuser_N = 0;
         return  ;
      }

      public bool gxTv_SdtSecUser_Secusercrtuser_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SecUserUpdUser_N" )]
      [  XmlElement( ElementName = "SecUserUpdUser_N"   )]
      public short gxTpr_Secuserupduser_N
      {
         get {
            return gxTv_SdtSecUser_Secuserupduser_N ;
         }

         set {
            gxTv_SdtSecUser_Secuserupduser_N = value;
            SetDirty("Secuserupduser_N");
         }

      }

      public void gxTv_SdtSecUser_Secuserupduser_N_SetNull( )
      {
         gxTv_SdtSecUser_Secuserupduser_N = 0;
         return  ;
      }

      public bool gxTv_SdtSecUser_Secuserupduser_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SecUserCrtDate_N" )]
      [  XmlElement( ElementName = "SecUserCrtDate_N"   )]
      public short gxTpr_Secusercrtdate_N
      {
         get {
            return gxTv_SdtSecUser_Secusercrtdate_N ;
         }

         set {
            gxTv_SdtSecUser_Secusercrtdate_N = value;
            SetDirty("Secusercrtdate_N");
         }

      }

      public void gxTv_SdtSecUser_Secusercrtdate_N_SetNull( )
      {
         gxTv_SdtSecUser_Secusercrtdate_N = 0;
         return  ;
      }

      public bool gxTv_SdtSecUser_Secusercrtdate_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SecUserUpdDate_N" )]
      [  XmlElement( ElementName = "SecUserUpdDate_N"   )]
      public short gxTpr_Secuserupddate_N
      {
         get {
            return gxTv_SdtSecUser_Secuserupddate_N ;
         }

         set {
            gxTv_SdtSecUser_Secuserupddate_N = value;
            SetDirty("Secuserupddate_N");
         }

      }

      public void gxTv_SdtSecUser_Secuserupddate_N_SetNull( )
      {
         gxTv_SdtSecUser_Secuserupddate_N = 0;
         return  ;
      }

      public bool gxTv_SdtSecUser_Secuserupddate_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SecUserWorkload_N" )]
      [  XmlElement( ElementName = "SecUserWorkload_N"   )]
      public short gxTpr_Secuserworkload_N
      {
         get {
            return gxTv_SdtSecUser_Secuserworkload_N ;
         }

         set {
            gxTv_SdtSecUser_Secuserworkload_N = value;
            SetDirty("Secuserworkload_N");
         }

      }

      public void gxTv_SdtSecUser_Secuserworkload_N_SetNull( )
      {
         gxTv_SdtSecUser_Secuserworkload_N = 0;
         return  ;
      }

      public bool gxTv_SdtSecUser_Secuserworkload_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtSecUser_Secusername = "";
         gxTv_SdtSecUser_Secuserpassword = "";
         gxTv_SdtSecUser_Secusercrtuser = "";
         gxTv_SdtSecUser_Secuserupduser = "";
         gxTv_SdtSecUser_Secusercrtdate = (DateTime)(DateTime.MinValue);
         gxTv_SdtSecUser_Secuserupddate = (DateTime)(DateTime.MinValue);
         gxTv_SdtSecUser_Mode = "";
         gxTv_SdtSecUser_Secusername_Z = "";
         gxTv_SdtSecUser_Secuserpassword_Z = "";
         gxTv_SdtSecUser_Secusercrtuser_Z = "";
         gxTv_SdtSecUser_Secuserupduser_Z = "";
         gxTv_SdtSecUser_Secusercrtdate_Z = (DateTime)(DateTime.MinValue);
         gxTv_SdtSecUser_Secuserupddate_Z = (DateTime)(DateTime.MinValue);
         datetime_STZ = (DateTime)(DateTime.MinValue);
         sDateCnv = "";
         sNumToPad = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "secuser", "GeneXus.Programs.wwpbaseobjects.secuser_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtSecUser_Secuserid ;
      private short gxTv_SdtSecUser_Initialized ;
      private short gxTv_SdtSecUser_Secuserid_Z ;
      private short gxTv_SdtSecUser_Secusercrtuser_N ;
      private short gxTv_SdtSecUser_Secuserupduser_N ;
      private short gxTv_SdtSecUser_Secusercrtdate_N ;
      private short gxTv_SdtSecUser_Secuserupddate_N ;
      private short gxTv_SdtSecUser_Secuserworkload_N ;
      private long gxTv_SdtSecUser_Secuserworkload ;
      private long gxTv_SdtSecUser_Secuserworkload_Z ;
      private String gxTv_SdtSecUser_Mode ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_SdtSecUser_Secusercrtdate ;
      private DateTime gxTv_SdtSecUser_Secuserupddate ;
      private DateTime gxTv_SdtSecUser_Secusercrtdate_Z ;
      private DateTime gxTv_SdtSecUser_Secuserupddate_Z ;
      private DateTime datetime_STZ ;
      private String gxTv_SdtSecUser_Secusername ;
      private String gxTv_SdtSecUser_Secuserpassword ;
      private String gxTv_SdtSecUser_Secusercrtuser ;
      private String gxTv_SdtSecUser_Secuserupduser ;
      private String gxTv_SdtSecUser_Secusername_Z ;
      private String gxTv_SdtSecUser_Secuserpassword_Z ;
      private String gxTv_SdtSecUser_Secusercrtuser_Z ;
      private String gxTv_SdtSecUser_Secuserupduser_Z ;
   }

   [DataContract(Name = @"WWPBaseObjects\SecUser", Namespace = "DataAnalysisPlatform")]
   public class SdtSecUser_RESTInterface : GxGenericCollectionItem<GeneXus.Programs.wwpbaseobjects.SdtSecUser>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSecUser_RESTInterface( ) : base()
      {
      }

      public SdtSecUser_RESTInterface( GeneXus.Programs.wwpbaseobjects.SdtSecUser psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "SecUserId" , Order = 0 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Secuserid
      {
         get {
            return sdt.gxTpr_Secuserid ;
         }

         set {
            sdt.gxTpr_Secuserid = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "SecUserName" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Secusername
      {
         get {
            return sdt.gxTpr_Secusername ;
         }

         set {
            sdt.gxTpr_Secusername = value;
         }

      }

      [DataMember( Name = "SecUserPassword" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Secuserpassword
      {
         get {
            return sdt.gxTpr_Secuserpassword ;
         }

         set {
            sdt.gxTpr_Secuserpassword = value;
         }

      }

      [DataMember( Name = "SecUserCrtUser" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Secusercrtuser
      {
         get {
            return sdt.gxTpr_Secusercrtuser ;
         }

         set {
            sdt.gxTpr_Secusercrtuser = value;
         }

      }

      [DataMember( Name = "SecUserUpdUser" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Secuserupduser
      {
         get {
            return sdt.gxTpr_Secuserupduser ;
         }

         set {
            sdt.gxTpr_Secuserupduser = value;
         }

      }

      [DataMember( Name = "SecUserCrtDate" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Secusercrtdate
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Secusercrtdate) ;
         }

         set {
            sdt.gxTpr_Secusercrtdate = DateTimeUtil.CToT2( value);
         }

      }

      [DataMember( Name = "SecUserUpdDate" , Order = 6 )]
      [GxSeudo()]
      public String gxTpr_Secuserupddate
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Secuserupddate) ;
         }

         set {
            sdt.gxTpr_Secuserupddate = DateTimeUtil.CToT2( value);
         }

      }

      [DataMember( Name = "SecUserWorkload" , Order = 7 )]
      [GxSeudo()]
      public String gxTpr_Secuserworkload
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Secuserworkload), 10, 0)) ;
         }

         set {
            sdt.gxTpr_Secuserworkload = (long)(NumberUtil.Val( value, "."));
         }

      }

      public GeneXus.Programs.wwpbaseobjects.SdtSecUser sdt
      {
         get {
            return (GeneXus.Programs.wwpbaseobjects.SdtSecUser)Sdt ;
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
            sdt = new GeneXus.Programs.wwpbaseobjects.SdtSecUser() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 8 )]
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

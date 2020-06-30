/*
               File: type_SdtSYS_Database
        Description: SYS_Database
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:8:51.85
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
   [XmlRoot(ElementName = "SYS_Database" )]
   [XmlType(TypeName =  "SYS_Database" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtSYS_Database : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSYS_Database( )
      {
      }

      public SdtSYS_Database( IGxContext context )
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

      public void Load( int AV365DatabaseID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(int)AV365DatabaseID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"DatabaseID", typeof(int)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "SYS_Database");
         metadata.Set("BT", "SYS_DATABASE");
         metadata.Set("PK", "[ \"DatabaseID\" ]");
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
         state.Add("gxTpr_Databaseid_Z");
         state.Add("gxTpr_Databasename_Z");
         state.Add("gxTpr_Connectionstring_Z");
         state.Add("gxTpr_Sys_databasecreator_Z");
         state.Add("gxTpr_Sys_databasecreatetime_Z_Nullable");
         state.Add("gxTpr_Sys_databasemodifier_Z");
         state.Add("gxTpr_Sys_databasemodifytime_Z_Nullable");
         state.Add("gxTpr_Sys_databasemodifier_N");
         state.Add("gxTpr_Sys_databasemodifytime_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtSYS_Database sdt ;
         sdt = (SdtSYS_Database)(source);
         gxTv_SdtSYS_Database_Databaseid = sdt.gxTv_SdtSYS_Database_Databaseid ;
         gxTv_SdtSYS_Database_Databasename = sdt.gxTv_SdtSYS_Database_Databasename ;
         gxTv_SdtSYS_Database_Connectionstring = sdt.gxTv_SdtSYS_Database_Connectionstring ;
         gxTv_SdtSYS_Database_Sys_databasecreator = sdt.gxTv_SdtSYS_Database_Sys_databasecreator ;
         gxTv_SdtSYS_Database_Sys_databasecreatetime = sdt.gxTv_SdtSYS_Database_Sys_databasecreatetime ;
         gxTv_SdtSYS_Database_Sys_databasemodifier = sdt.gxTv_SdtSYS_Database_Sys_databasemodifier ;
         gxTv_SdtSYS_Database_Sys_databasemodifytime = sdt.gxTv_SdtSYS_Database_Sys_databasemodifytime ;
         gxTv_SdtSYS_Database_Mode = sdt.gxTv_SdtSYS_Database_Mode ;
         gxTv_SdtSYS_Database_Initialized = sdt.gxTv_SdtSYS_Database_Initialized ;
         gxTv_SdtSYS_Database_Databaseid_Z = sdt.gxTv_SdtSYS_Database_Databaseid_Z ;
         gxTv_SdtSYS_Database_Databasename_Z = sdt.gxTv_SdtSYS_Database_Databasename_Z ;
         gxTv_SdtSYS_Database_Connectionstring_Z = sdt.gxTv_SdtSYS_Database_Connectionstring_Z ;
         gxTv_SdtSYS_Database_Sys_databasecreator_Z = sdt.gxTv_SdtSYS_Database_Sys_databasecreator_Z ;
         gxTv_SdtSYS_Database_Sys_databasecreatetime_Z = sdt.gxTv_SdtSYS_Database_Sys_databasecreatetime_Z ;
         gxTv_SdtSYS_Database_Sys_databasemodifier_Z = sdt.gxTv_SdtSYS_Database_Sys_databasemodifier_Z ;
         gxTv_SdtSYS_Database_Sys_databasemodifytime_Z = sdt.gxTv_SdtSYS_Database_Sys_databasemodifytime_Z ;
         gxTv_SdtSYS_Database_Sys_databasemodifier_N = sdt.gxTv_SdtSYS_Database_Sys_databasemodifier_N ;
         gxTv_SdtSYS_Database_Sys_databasemodifytime_N = sdt.gxTv_SdtSYS_Database_Sys_databasemodifytime_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("DatabaseID", gxTv_SdtSYS_Database_Databaseid, false);
         AddObjectProperty("DatabaseName", gxTv_SdtSYS_Database_Databasename, false);
         AddObjectProperty("ConnectionString", gxTv_SdtSYS_Database_Connectionstring, false);
         AddObjectProperty("SYS_DatabaseCreator", gxTv_SdtSYS_Database_Sys_databasecreator, false);
         datetime_STZ = gxTv_SdtSYS_Database_Sys_databasecreatetime;
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
         AddObjectProperty("SYS_DatabaseCreateTime", sDateCnv, false);
         AddObjectProperty("SYS_DatabaseModifier", gxTv_SdtSYS_Database_Sys_databasemodifier, false);
         AddObjectProperty("SYS_DatabaseModifier_N", gxTv_SdtSYS_Database_Sys_databasemodifier_N, false);
         datetime_STZ = gxTv_SdtSYS_Database_Sys_databasemodifytime;
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
         AddObjectProperty("SYS_DatabaseModifyTime", sDateCnv, false);
         AddObjectProperty("SYS_DatabaseModifyTime_N", gxTv_SdtSYS_Database_Sys_databasemodifytime_N, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtSYS_Database_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtSYS_Database_Initialized, false);
            AddObjectProperty("DatabaseID_Z", gxTv_SdtSYS_Database_Databaseid_Z, false);
            AddObjectProperty("DatabaseName_Z", gxTv_SdtSYS_Database_Databasename_Z, false);
            AddObjectProperty("ConnectionString_Z", gxTv_SdtSYS_Database_Connectionstring_Z, false);
            AddObjectProperty("SYS_DatabaseCreator_Z", gxTv_SdtSYS_Database_Sys_databasecreator_Z, false);
            datetime_STZ = gxTv_SdtSYS_Database_Sys_databasecreatetime_Z;
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
            AddObjectProperty("SYS_DatabaseCreateTime_Z", sDateCnv, false);
            AddObjectProperty("SYS_DatabaseModifier_Z", gxTv_SdtSYS_Database_Sys_databasemodifier_Z, false);
            datetime_STZ = gxTv_SdtSYS_Database_Sys_databasemodifytime_Z;
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
            AddObjectProperty("SYS_DatabaseModifyTime_Z", sDateCnv, false);
            AddObjectProperty("SYS_DatabaseModifier_N", gxTv_SdtSYS_Database_Sys_databasemodifier_N, false);
            AddObjectProperty("SYS_DatabaseModifyTime_N", gxTv_SdtSYS_Database_Sys_databasemodifytime_N, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtSYS_Database sdt )
      {
         if ( sdt.IsDirty("DatabaseID") )
         {
            gxTv_SdtSYS_Database_Databaseid = sdt.gxTv_SdtSYS_Database_Databaseid ;
         }
         if ( sdt.IsDirty("DatabaseName") )
         {
            gxTv_SdtSYS_Database_Databasename = sdt.gxTv_SdtSYS_Database_Databasename ;
         }
         if ( sdt.IsDirty("ConnectionString") )
         {
            gxTv_SdtSYS_Database_Connectionstring = sdt.gxTv_SdtSYS_Database_Connectionstring ;
         }
         if ( sdt.IsDirty("SYS_DatabaseCreator") )
         {
            gxTv_SdtSYS_Database_Sys_databasecreator = sdt.gxTv_SdtSYS_Database_Sys_databasecreator ;
         }
         if ( sdt.IsDirty("SYS_DatabaseCreateTime") )
         {
            gxTv_SdtSYS_Database_Sys_databasecreatetime = sdt.gxTv_SdtSYS_Database_Sys_databasecreatetime ;
         }
         if ( sdt.IsDirty("SYS_DatabaseModifier") )
         {
            gxTv_SdtSYS_Database_Sys_databasemodifier = sdt.gxTv_SdtSYS_Database_Sys_databasemodifier ;
         }
         if ( sdt.IsDirty("SYS_DatabaseModifyTime") )
         {
            gxTv_SdtSYS_Database_Sys_databasemodifytime = sdt.gxTv_SdtSYS_Database_Sys_databasemodifytime ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "DatabaseID" )]
      [  XmlElement( ElementName = "DatabaseID"   )]
      public int gxTpr_Databaseid
      {
         get {
            return gxTv_SdtSYS_Database_Databaseid ;
         }

         set {
            if ( gxTv_SdtSYS_Database_Databaseid != value )
            {
               gxTv_SdtSYS_Database_Mode = "INS";
               this.gxTv_SdtSYS_Database_Databaseid_Z_SetNull( );
               this.gxTv_SdtSYS_Database_Databasename_Z_SetNull( );
               this.gxTv_SdtSYS_Database_Connectionstring_Z_SetNull( );
               this.gxTv_SdtSYS_Database_Sys_databasecreator_Z_SetNull( );
               this.gxTv_SdtSYS_Database_Sys_databasecreatetime_Z_SetNull( );
               this.gxTv_SdtSYS_Database_Sys_databasemodifier_Z_SetNull( );
               this.gxTv_SdtSYS_Database_Sys_databasemodifytime_Z_SetNull( );
            }
            gxTv_SdtSYS_Database_Databaseid = value;
            SetDirty("Databaseid");
         }

      }

      [  SoapElement( ElementName = "DatabaseName" )]
      [  XmlElement( ElementName = "DatabaseName"   )]
      public String gxTpr_Databasename
      {
         get {
            return gxTv_SdtSYS_Database_Databasename ;
         }

         set {
            gxTv_SdtSYS_Database_Databasename = value;
            SetDirty("Databasename");
         }

      }

      [  SoapElement( ElementName = "ConnectionString" )]
      [  XmlElement( ElementName = "ConnectionString"   )]
      public String gxTpr_Connectionstring
      {
         get {
            return gxTv_SdtSYS_Database_Connectionstring ;
         }

         set {
            gxTv_SdtSYS_Database_Connectionstring = value;
            SetDirty("Connectionstring");
         }

      }

      [  SoapElement( ElementName = "SYS_DatabaseCreator" )]
      [  XmlElement( ElementName = "SYS_DatabaseCreator"   )]
      public String gxTpr_Sys_databasecreator
      {
         get {
            return gxTv_SdtSYS_Database_Sys_databasecreator ;
         }

         set {
            gxTv_SdtSYS_Database_Sys_databasecreator = value;
            SetDirty("Sys_databasecreator");
         }

      }

      [  SoapElement( ElementName = "SYS_DatabaseCreateTime" )]
      [  XmlElement( ElementName = "SYS_DatabaseCreateTime"  , IsNullable=true )]
      public string gxTpr_Sys_databasecreatetime_Nullable
      {
         get {
            if ( gxTv_SdtSYS_Database_Sys_databasecreatetime == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtSYS_Database_Sys_databasecreatetime).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtSYS_Database_Sys_databasecreatetime = DateTime.MinValue;
            else
               gxTv_SdtSYS_Database_Sys_databasecreatetime = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Sys_databasecreatetime
      {
         get {
            return gxTv_SdtSYS_Database_Sys_databasecreatetime ;
         }

         set {
            gxTv_SdtSYS_Database_Sys_databasecreatetime = value;
            SetDirty("Sys_databasecreatetime");
         }

      }

      [  SoapElement( ElementName = "SYS_DatabaseModifier" )]
      [  XmlElement( ElementName = "SYS_DatabaseModifier"   )]
      public String gxTpr_Sys_databasemodifier
      {
         get {
            return gxTv_SdtSYS_Database_Sys_databasemodifier ;
         }

         set {
            gxTv_SdtSYS_Database_Sys_databasemodifier_N = 0;
            gxTv_SdtSYS_Database_Sys_databasemodifier = value;
            SetDirty("Sys_databasemodifier");
         }

      }

      public void gxTv_SdtSYS_Database_Sys_databasemodifier_SetNull( )
      {
         gxTv_SdtSYS_Database_Sys_databasemodifier_N = 1;
         gxTv_SdtSYS_Database_Sys_databasemodifier = "";
         return  ;
      }

      public bool gxTv_SdtSYS_Database_Sys_databasemodifier_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_DatabaseModifyTime" )]
      [  XmlElement( ElementName = "SYS_DatabaseModifyTime"  , IsNullable=true )]
      public string gxTpr_Sys_databasemodifytime_Nullable
      {
         get {
            if ( gxTv_SdtSYS_Database_Sys_databasemodifytime == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtSYS_Database_Sys_databasemodifytime).value ;
         }

         set {
            gxTv_SdtSYS_Database_Sys_databasemodifytime_N = 0;
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtSYS_Database_Sys_databasemodifytime = DateTime.MinValue;
            else
               gxTv_SdtSYS_Database_Sys_databasemodifytime = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Sys_databasemodifytime
      {
         get {
            return gxTv_SdtSYS_Database_Sys_databasemodifytime ;
         }

         set {
            gxTv_SdtSYS_Database_Sys_databasemodifytime_N = 0;
            gxTv_SdtSYS_Database_Sys_databasemodifytime = value;
            SetDirty("Sys_databasemodifytime");
         }

      }

      public void gxTv_SdtSYS_Database_Sys_databasemodifytime_SetNull( )
      {
         gxTv_SdtSYS_Database_Sys_databasemodifytime_N = 1;
         gxTv_SdtSYS_Database_Sys_databasemodifytime = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtSYS_Database_Sys_databasemodifytime_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtSYS_Database_Mode ;
         }

         set {
            gxTv_SdtSYS_Database_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtSYS_Database_Mode_SetNull( )
      {
         gxTv_SdtSYS_Database_Mode = "";
         return  ;
      }

      public bool gxTv_SdtSYS_Database_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtSYS_Database_Initialized ;
         }

         set {
            gxTv_SdtSYS_Database_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtSYS_Database_Initialized_SetNull( )
      {
         gxTv_SdtSYS_Database_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtSYS_Database_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "DatabaseID_Z" )]
      [  XmlElement( ElementName = "DatabaseID_Z"   )]
      public int gxTpr_Databaseid_Z
      {
         get {
            return gxTv_SdtSYS_Database_Databaseid_Z ;
         }

         set {
            gxTv_SdtSYS_Database_Databaseid_Z = value;
            SetDirty("Databaseid_Z");
         }

      }

      public void gxTv_SdtSYS_Database_Databaseid_Z_SetNull( )
      {
         gxTv_SdtSYS_Database_Databaseid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtSYS_Database_Databaseid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "DatabaseName_Z" )]
      [  XmlElement( ElementName = "DatabaseName_Z"   )]
      public String gxTpr_Databasename_Z
      {
         get {
            return gxTv_SdtSYS_Database_Databasename_Z ;
         }

         set {
            gxTv_SdtSYS_Database_Databasename_Z = value;
            SetDirty("Databasename_Z");
         }

      }

      public void gxTv_SdtSYS_Database_Databasename_Z_SetNull( )
      {
         gxTv_SdtSYS_Database_Databasename_Z = "";
         return  ;
      }

      public bool gxTv_SdtSYS_Database_Databasename_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "ConnectionString_Z" )]
      [  XmlElement( ElementName = "ConnectionString_Z"   )]
      public String gxTpr_Connectionstring_Z
      {
         get {
            return gxTv_SdtSYS_Database_Connectionstring_Z ;
         }

         set {
            gxTv_SdtSYS_Database_Connectionstring_Z = value;
            SetDirty("Connectionstring_Z");
         }

      }

      public void gxTv_SdtSYS_Database_Connectionstring_Z_SetNull( )
      {
         gxTv_SdtSYS_Database_Connectionstring_Z = "";
         return  ;
      }

      public bool gxTv_SdtSYS_Database_Connectionstring_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_DatabaseCreator_Z" )]
      [  XmlElement( ElementName = "SYS_DatabaseCreator_Z"   )]
      public String gxTpr_Sys_databasecreator_Z
      {
         get {
            return gxTv_SdtSYS_Database_Sys_databasecreator_Z ;
         }

         set {
            gxTv_SdtSYS_Database_Sys_databasecreator_Z = value;
            SetDirty("Sys_databasecreator_Z");
         }

      }

      public void gxTv_SdtSYS_Database_Sys_databasecreator_Z_SetNull( )
      {
         gxTv_SdtSYS_Database_Sys_databasecreator_Z = "";
         return  ;
      }

      public bool gxTv_SdtSYS_Database_Sys_databasecreator_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_DatabaseCreateTime_Z" )]
      [  XmlElement( ElementName = "SYS_DatabaseCreateTime_Z"  , IsNullable=true )]
      public string gxTpr_Sys_databasecreatetime_Z_Nullable
      {
         get {
            if ( gxTv_SdtSYS_Database_Sys_databasecreatetime_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtSYS_Database_Sys_databasecreatetime_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtSYS_Database_Sys_databasecreatetime_Z = DateTime.MinValue;
            else
               gxTv_SdtSYS_Database_Sys_databasecreatetime_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Sys_databasecreatetime_Z
      {
         get {
            return gxTv_SdtSYS_Database_Sys_databasecreatetime_Z ;
         }

         set {
            gxTv_SdtSYS_Database_Sys_databasecreatetime_Z = value;
            SetDirty("Sys_databasecreatetime_Z");
         }

      }

      public void gxTv_SdtSYS_Database_Sys_databasecreatetime_Z_SetNull( )
      {
         gxTv_SdtSYS_Database_Sys_databasecreatetime_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtSYS_Database_Sys_databasecreatetime_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_DatabaseModifier_Z" )]
      [  XmlElement( ElementName = "SYS_DatabaseModifier_Z"   )]
      public String gxTpr_Sys_databasemodifier_Z
      {
         get {
            return gxTv_SdtSYS_Database_Sys_databasemodifier_Z ;
         }

         set {
            gxTv_SdtSYS_Database_Sys_databasemodifier_Z = value;
            SetDirty("Sys_databasemodifier_Z");
         }

      }

      public void gxTv_SdtSYS_Database_Sys_databasemodifier_Z_SetNull( )
      {
         gxTv_SdtSYS_Database_Sys_databasemodifier_Z = "";
         return  ;
      }

      public bool gxTv_SdtSYS_Database_Sys_databasemodifier_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_DatabaseModifyTime_Z" )]
      [  XmlElement( ElementName = "SYS_DatabaseModifyTime_Z"  , IsNullable=true )]
      public string gxTpr_Sys_databasemodifytime_Z_Nullable
      {
         get {
            if ( gxTv_SdtSYS_Database_Sys_databasemodifytime_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtSYS_Database_Sys_databasemodifytime_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtSYS_Database_Sys_databasemodifytime_Z = DateTime.MinValue;
            else
               gxTv_SdtSYS_Database_Sys_databasemodifytime_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Sys_databasemodifytime_Z
      {
         get {
            return gxTv_SdtSYS_Database_Sys_databasemodifytime_Z ;
         }

         set {
            gxTv_SdtSYS_Database_Sys_databasemodifytime_Z = value;
            SetDirty("Sys_databasemodifytime_Z");
         }

      }

      public void gxTv_SdtSYS_Database_Sys_databasemodifytime_Z_SetNull( )
      {
         gxTv_SdtSYS_Database_Sys_databasemodifytime_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtSYS_Database_Sys_databasemodifytime_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_DatabaseModifier_N" )]
      [  XmlElement( ElementName = "SYS_DatabaseModifier_N"   )]
      public short gxTpr_Sys_databasemodifier_N
      {
         get {
            return gxTv_SdtSYS_Database_Sys_databasemodifier_N ;
         }

         set {
            gxTv_SdtSYS_Database_Sys_databasemodifier_N = value;
            SetDirty("Sys_databasemodifier_N");
         }

      }

      public void gxTv_SdtSYS_Database_Sys_databasemodifier_N_SetNull( )
      {
         gxTv_SdtSYS_Database_Sys_databasemodifier_N = 0;
         return  ;
      }

      public bool gxTv_SdtSYS_Database_Sys_databasemodifier_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_DatabaseModifyTime_N" )]
      [  XmlElement( ElementName = "SYS_DatabaseModifyTime_N"   )]
      public short gxTpr_Sys_databasemodifytime_N
      {
         get {
            return gxTv_SdtSYS_Database_Sys_databasemodifytime_N ;
         }

         set {
            gxTv_SdtSYS_Database_Sys_databasemodifytime_N = value;
            SetDirty("Sys_databasemodifytime_N");
         }

      }

      public void gxTv_SdtSYS_Database_Sys_databasemodifytime_N_SetNull( )
      {
         gxTv_SdtSYS_Database_Sys_databasemodifytime_N = 0;
         return  ;
      }

      public bool gxTv_SdtSYS_Database_Sys_databasemodifytime_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtSYS_Database_Databasename = "";
         gxTv_SdtSYS_Database_Connectionstring = "";
         gxTv_SdtSYS_Database_Sys_databasecreator = "";
         gxTv_SdtSYS_Database_Sys_databasecreatetime = (DateTime)(DateTime.MinValue);
         gxTv_SdtSYS_Database_Sys_databasemodifier = "";
         gxTv_SdtSYS_Database_Sys_databasemodifytime = (DateTime)(DateTime.MinValue);
         gxTv_SdtSYS_Database_Mode = "";
         gxTv_SdtSYS_Database_Databasename_Z = "";
         gxTv_SdtSYS_Database_Connectionstring_Z = "";
         gxTv_SdtSYS_Database_Sys_databasecreator_Z = "";
         gxTv_SdtSYS_Database_Sys_databasecreatetime_Z = (DateTime)(DateTime.MinValue);
         gxTv_SdtSYS_Database_Sys_databasemodifier_Z = "";
         gxTv_SdtSYS_Database_Sys_databasemodifytime_Z = (DateTime)(DateTime.MinValue);
         datetime_STZ = (DateTime)(DateTime.MinValue);
         sDateCnv = "";
         sNumToPad = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "sys_database", "GeneXus.Programs.sys_database_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtSYS_Database_Initialized ;
      private short gxTv_SdtSYS_Database_Sys_databasemodifier_N ;
      private short gxTv_SdtSYS_Database_Sys_databasemodifytime_N ;
      private int gxTv_SdtSYS_Database_Databaseid ;
      private int gxTv_SdtSYS_Database_Databaseid_Z ;
      private String gxTv_SdtSYS_Database_Mode ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_SdtSYS_Database_Sys_databasecreatetime ;
      private DateTime gxTv_SdtSYS_Database_Sys_databasemodifytime ;
      private DateTime gxTv_SdtSYS_Database_Sys_databasecreatetime_Z ;
      private DateTime gxTv_SdtSYS_Database_Sys_databasemodifytime_Z ;
      private DateTime datetime_STZ ;
      private String gxTv_SdtSYS_Database_Databasename ;
      private String gxTv_SdtSYS_Database_Connectionstring ;
      private String gxTv_SdtSYS_Database_Sys_databasecreator ;
      private String gxTv_SdtSYS_Database_Sys_databasemodifier ;
      private String gxTv_SdtSYS_Database_Databasename_Z ;
      private String gxTv_SdtSYS_Database_Connectionstring_Z ;
      private String gxTv_SdtSYS_Database_Sys_databasecreator_Z ;
      private String gxTv_SdtSYS_Database_Sys_databasemodifier_Z ;
   }

   [DataContract(Name = @"SYS_Database", Namespace = "DataAnalysisPlatform")]
   public class SdtSYS_Database_RESTInterface : GxGenericCollectionItem<SdtSYS_Database>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSYS_Database_RESTInterface( ) : base()
      {
      }

      public SdtSYS_Database_RESTInterface( SdtSYS_Database psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "DatabaseID" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Databaseid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Databaseid), 9, 0)) ;
         }

         set {
            sdt.gxTpr_Databaseid = (int)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "DatabaseName" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Databasename
      {
         get {
            return sdt.gxTpr_Databasename ;
         }

         set {
            sdt.gxTpr_Databasename = value;
         }

      }

      [DataMember( Name = "ConnectionString" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Connectionstring
      {
         get {
            return sdt.gxTpr_Connectionstring ;
         }

         set {
            sdt.gxTpr_Connectionstring = value;
         }

      }

      [DataMember( Name = "SYS_DatabaseCreator" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Sys_databasecreator
      {
         get {
            return sdt.gxTpr_Sys_databasecreator ;
         }

         set {
            sdt.gxTpr_Sys_databasecreator = value;
         }

      }

      [DataMember( Name = "SYS_DatabaseCreateTime" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Sys_databasecreatetime
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Sys_databasecreatetime) ;
         }

         set {
            sdt.gxTpr_Sys_databasecreatetime = DateTimeUtil.CToT2( value);
         }

      }

      [DataMember( Name = "SYS_DatabaseModifier" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Sys_databasemodifier
      {
         get {
            return sdt.gxTpr_Sys_databasemodifier ;
         }

         set {
            sdt.gxTpr_Sys_databasemodifier = value;
         }

      }

      [DataMember( Name = "SYS_DatabaseModifyTime" , Order = 6 )]
      [GxSeudo()]
      public String gxTpr_Sys_databasemodifytime
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Sys_databasemodifytime) ;
         }

         set {
            sdt.gxTpr_Sys_databasemodifytime = DateTimeUtil.CToT2( value);
         }

      }

      public SdtSYS_Database sdt
      {
         get {
            return (SdtSYS_Database)Sdt ;
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
            sdt = new SdtSYS_Database() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 7 )]
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

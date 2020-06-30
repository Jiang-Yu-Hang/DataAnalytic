/*
               File: type_SdtSYS_Role
        Description: SYS_Role
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:39:2.71
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
   [XmlRoot(ElementName = "SYS_Role" )]
   [XmlType(TypeName =  "SYS_Role" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtSYS_Role : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSYS_Role( )
      {
      }

      public SdtSYS_Role( IGxContext context )
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

      public void Load( Guid AV361RoleID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(Guid)AV361RoleID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"RoleID", typeof(Guid)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "SYS_Role");
         metadata.Set("BT", "SYS_ROLE");
         metadata.Set("PK", "[ \"RoleID\" ]");
         metadata.Set("PKAssigned", "[ \"RoleID\" ]");
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
         state.Add("gxTpr_Roleid_Z");
         state.Add("gxTpr_Sys_roletenantcode_Z");
         state.Add("gxTpr_Rolename_Z");
         state.Add("gxTpr_Roletype_Z");
         state.Add("gxTpr_Sys_rolecreator_Z");
         state.Add("gxTpr_Sys_rolecreatetime_Z_Nullable");
         state.Add("gxTpr_Sys_rolemodifier_Z");
         state.Add("gxTpr_Sys_rolemodifytime_Z_Nullable");
         state.Add("gxTpr_Sys_roleisdeleted_Z");
         state.Add("gxTpr_Sys_roletenantcode_N");
         state.Add("gxTpr_Sys_roledescription_N");
         state.Add("gxTpr_Sys_rolemodifier_N");
         state.Add("gxTpr_Sys_rolemodifytime_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtSYS_Role sdt ;
         sdt = (SdtSYS_Role)(source);
         gxTv_SdtSYS_Role_Roleid = sdt.gxTv_SdtSYS_Role_Roleid ;
         gxTv_SdtSYS_Role_Sys_roletenantcode = sdt.gxTv_SdtSYS_Role_Sys_roletenantcode ;
         gxTv_SdtSYS_Role_Rolename = sdt.gxTv_SdtSYS_Role_Rolename ;
         gxTv_SdtSYS_Role_Roletype = sdt.gxTv_SdtSYS_Role_Roletype ;
         gxTv_SdtSYS_Role_Sys_roledescription = sdt.gxTv_SdtSYS_Role_Sys_roledescription ;
         gxTv_SdtSYS_Role_Sys_rolecreator = sdt.gxTv_SdtSYS_Role_Sys_rolecreator ;
         gxTv_SdtSYS_Role_Sys_rolecreatetime = sdt.gxTv_SdtSYS_Role_Sys_rolecreatetime ;
         gxTv_SdtSYS_Role_Sys_rolemodifier = sdt.gxTv_SdtSYS_Role_Sys_rolemodifier ;
         gxTv_SdtSYS_Role_Sys_rolemodifytime = sdt.gxTv_SdtSYS_Role_Sys_rolemodifytime ;
         gxTv_SdtSYS_Role_Sys_roleisdeleted = sdt.gxTv_SdtSYS_Role_Sys_roleisdeleted ;
         gxTv_SdtSYS_Role_Mode = sdt.gxTv_SdtSYS_Role_Mode ;
         gxTv_SdtSYS_Role_Initialized = sdt.gxTv_SdtSYS_Role_Initialized ;
         gxTv_SdtSYS_Role_Roleid_Z = sdt.gxTv_SdtSYS_Role_Roleid_Z ;
         gxTv_SdtSYS_Role_Sys_roletenantcode_Z = sdt.gxTv_SdtSYS_Role_Sys_roletenantcode_Z ;
         gxTv_SdtSYS_Role_Rolename_Z = sdt.gxTv_SdtSYS_Role_Rolename_Z ;
         gxTv_SdtSYS_Role_Roletype_Z = sdt.gxTv_SdtSYS_Role_Roletype_Z ;
         gxTv_SdtSYS_Role_Sys_rolecreator_Z = sdt.gxTv_SdtSYS_Role_Sys_rolecreator_Z ;
         gxTv_SdtSYS_Role_Sys_rolecreatetime_Z = sdt.gxTv_SdtSYS_Role_Sys_rolecreatetime_Z ;
         gxTv_SdtSYS_Role_Sys_rolemodifier_Z = sdt.gxTv_SdtSYS_Role_Sys_rolemodifier_Z ;
         gxTv_SdtSYS_Role_Sys_rolemodifytime_Z = sdt.gxTv_SdtSYS_Role_Sys_rolemodifytime_Z ;
         gxTv_SdtSYS_Role_Sys_roleisdeleted_Z = sdt.gxTv_SdtSYS_Role_Sys_roleisdeleted_Z ;
         gxTv_SdtSYS_Role_Sys_roletenantcode_N = sdt.gxTv_SdtSYS_Role_Sys_roletenantcode_N ;
         gxTv_SdtSYS_Role_Sys_roledescription_N = sdt.gxTv_SdtSYS_Role_Sys_roledescription_N ;
         gxTv_SdtSYS_Role_Sys_rolemodifier_N = sdt.gxTv_SdtSYS_Role_Sys_rolemodifier_N ;
         gxTv_SdtSYS_Role_Sys_rolemodifytime_N = sdt.gxTv_SdtSYS_Role_Sys_rolemodifytime_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("RoleID", gxTv_SdtSYS_Role_Roleid, false);
         AddObjectProperty("SYS_RoleTenantCode", gxTv_SdtSYS_Role_Sys_roletenantcode, false);
         AddObjectProperty("SYS_RoleTenantCode_N", gxTv_SdtSYS_Role_Sys_roletenantcode_N, false);
         AddObjectProperty("RoleName", gxTv_SdtSYS_Role_Rolename, false);
         AddObjectProperty("RoleType", gxTv_SdtSYS_Role_Roletype, false);
         AddObjectProperty("SYS_RoleDescription", gxTv_SdtSYS_Role_Sys_roledescription, false);
         AddObjectProperty("SYS_RoleDescription_N", gxTv_SdtSYS_Role_Sys_roledescription_N, false);
         AddObjectProperty("SYS_RoleCreator", gxTv_SdtSYS_Role_Sys_rolecreator, false);
         datetime_STZ = gxTv_SdtSYS_Role_Sys_rolecreatetime;
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
         AddObjectProperty("SYS_RoleCreateTime", sDateCnv, false);
         AddObjectProperty("SYS_RoleModifier", gxTv_SdtSYS_Role_Sys_rolemodifier, false);
         AddObjectProperty("SYS_RoleModifier_N", gxTv_SdtSYS_Role_Sys_rolemodifier_N, false);
         datetime_STZ = gxTv_SdtSYS_Role_Sys_rolemodifytime;
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
         AddObjectProperty("SYS_RoleModifyTime", sDateCnv, false);
         AddObjectProperty("SYS_RoleModifyTime_N", gxTv_SdtSYS_Role_Sys_rolemodifytime_N, false);
         AddObjectProperty("SYS_RoleIsDeleted", gxTv_SdtSYS_Role_Sys_roleisdeleted, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtSYS_Role_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtSYS_Role_Initialized, false);
            AddObjectProperty("RoleID_Z", gxTv_SdtSYS_Role_Roleid_Z, false);
            AddObjectProperty("SYS_RoleTenantCode_Z", gxTv_SdtSYS_Role_Sys_roletenantcode_Z, false);
            AddObjectProperty("RoleName_Z", gxTv_SdtSYS_Role_Rolename_Z, false);
            AddObjectProperty("RoleType_Z", gxTv_SdtSYS_Role_Roletype_Z, false);
            AddObjectProperty("SYS_RoleCreator_Z", gxTv_SdtSYS_Role_Sys_rolecreator_Z, false);
            datetime_STZ = gxTv_SdtSYS_Role_Sys_rolecreatetime_Z;
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
            AddObjectProperty("SYS_RoleCreateTime_Z", sDateCnv, false);
            AddObjectProperty("SYS_RoleModifier_Z", gxTv_SdtSYS_Role_Sys_rolemodifier_Z, false);
            datetime_STZ = gxTv_SdtSYS_Role_Sys_rolemodifytime_Z;
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
            AddObjectProperty("SYS_RoleModifyTime_Z", sDateCnv, false);
            AddObjectProperty("SYS_RoleIsDeleted_Z", gxTv_SdtSYS_Role_Sys_roleisdeleted_Z, false);
            AddObjectProperty("SYS_RoleTenantCode_N", gxTv_SdtSYS_Role_Sys_roletenantcode_N, false);
            AddObjectProperty("SYS_RoleDescription_N", gxTv_SdtSYS_Role_Sys_roledescription_N, false);
            AddObjectProperty("SYS_RoleModifier_N", gxTv_SdtSYS_Role_Sys_rolemodifier_N, false);
            AddObjectProperty("SYS_RoleModifyTime_N", gxTv_SdtSYS_Role_Sys_rolemodifytime_N, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtSYS_Role sdt )
      {
         if ( sdt.IsDirty("RoleID") )
         {
            gxTv_SdtSYS_Role_Roleid = sdt.gxTv_SdtSYS_Role_Roleid ;
         }
         if ( sdt.IsDirty("SYS_RoleTenantCode") )
         {
            gxTv_SdtSYS_Role_Sys_roletenantcode = sdt.gxTv_SdtSYS_Role_Sys_roletenantcode ;
         }
         if ( sdt.IsDirty("RoleName") )
         {
            gxTv_SdtSYS_Role_Rolename = sdt.gxTv_SdtSYS_Role_Rolename ;
         }
         if ( sdt.IsDirty("RoleType") )
         {
            gxTv_SdtSYS_Role_Roletype = sdt.gxTv_SdtSYS_Role_Roletype ;
         }
         if ( sdt.IsDirty("SYS_RoleDescription") )
         {
            gxTv_SdtSYS_Role_Sys_roledescription = sdt.gxTv_SdtSYS_Role_Sys_roledescription ;
         }
         if ( sdt.IsDirty("SYS_RoleCreator") )
         {
            gxTv_SdtSYS_Role_Sys_rolecreator = sdt.gxTv_SdtSYS_Role_Sys_rolecreator ;
         }
         if ( sdt.IsDirty("SYS_RoleCreateTime") )
         {
            gxTv_SdtSYS_Role_Sys_rolecreatetime = sdt.gxTv_SdtSYS_Role_Sys_rolecreatetime ;
         }
         if ( sdt.IsDirty("SYS_RoleModifier") )
         {
            gxTv_SdtSYS_Role_Sys_rolemodifier = sdt.gxTv_SdtSYS_Role_Sys_rolemodifier ;
         }
         if ( sdt.IsDirty("SYS_RoleModifyTime") )
         {
            gxTv_SdtSYS_Role_Sys_rolemodifytime = sdt.gxTv_SdtSYS_Role_Sys_rolemodifytime ;
         }
         if ( sdt.IsDirty("SYS_RoleIsDeleted") )
         {
            gxTv_SdtSYS_Role_Sys_roleisdeleted = sdt.gxTv_SdtSYS_Role_Sys_roleisdeleted ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "RoleID" )]
      [  XmlElement( ElementName = "RoleID"   )]
      public Guid gxTpr_Roleid
      {
         get {
            return gxTv_SdtSYS_Role_Roleid ;
         }

         set {
            if ( gxTv_SdtSYS_Role_Roleid != value )
            {
               gxTv_SdtSYS_Role_Mode = "INS";
               this.gxTv_SdtSYS_Role_Roleid_Z_SetNull( );
               this.gxTv_SdtSYS_Role_Sys_roletenantcode_Z_SetNull( );
               this.gxTv_SdtSYS_Role_Rolename_Z_SetNull( );
               this.gxTv_SdtSYS_Role_Roletype_Z_SetNull( );
               this.gxTv_SdtSYS_Role_Sys_rolecreator_Z_SetNull( );
               this.gxTv_SdtSYS_Role_Sys_rolecreatetime_Z_SetNull( );
               this.gxTv_SdtSYS_Role_Sys_rolemodifier_Z_SetNull( );
               this.gxTv_SdtSYS_Role_Sys_rolemodifytime_Z_SetNull( );
               this.gxTv_SdtSYS_Role_Sys_roleisdeleted_Z_SetNull( );
            }
            gxTv_SdtSYS_Role_Roleid = (Guid)(value);
            SetDirty("Roleid");
         }

      }

      [  SoapElement( ElementName = "SYS_RoleTenantCode" )]
      [  XmlElement( ElementName = "SYS_RoleTenantCode"   )]
      public String gxTpr_Sys_roletenantcode
      {
         get {
            return gxTv_SdtSYS_Role_Sys_roletenantcode ;
         }

         set {
            gxTv_SdtSYS_Role_Sys_roletenantcode_N = 0;
            gxTv_SdtSYS_Role_Sys_roletenantcode = value;
            SetDirty("Sys_roletenantcode");
         }

      }

      public void gxTv_SdtSYS_Role_Sys_roletenantcode_SetNull( )
      {
         gxTv_SdtSYS_Role_Sys_roletenantcode_N = 1;
         gxTv_SdtSYS_Role_Sys_roletenantcode = "";
         return  ;
      }

      public bool gxTv_SdtSYS_Role_Sys_roletenantcode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "RoleName" )]
      [  XmlElement( ElementName = "RoleName"   )]
      public String gxTpr_Rolename
      {
         get {
            return gxTv_SdtSYS_Role_Rolename ;
         }

         set {
            gxTv_SdtSYS_Role_Rolename = value;
            SetDirty("Rolename");
         }

      }

      [  SoapElement( ElementName = "RoleType" )]
      [  XmlElement( ElementName = "RoleType"   )]
      public int gxTpr_Roletype
      {
         get {
            return gxTv_SdtSYS_Role_Roletype ;
         }

         set {
            gxTv_SdtSYS_Role_Roletype = value;
            SetDirty("Roletype");
         }

      }

      [  SoapElement( ElementName = "SYS_RoleDescription" )]
      [  XmlElement( ElementName = "SYS_RoleDescription"   )]
      public String gxTpr_Sys_roledescription
      {
         get {
            return gxTv_SdtSYS_Role_Sys_roledescription ;
         }

         set {
            gxTv_SdtSYS_Role_Sys_roledescription_N = 0;
            gxTv_SdtSYS_Role_Sys_roledescription = value;
            SetDirty("Sys_roledescription");
         }

      }

      public void gxTv_SdtSYS_Role_Sys_roledescription_SetNull( )
      {
         gxTv_SdtSYS_Role_Sys_roledescription_N = 1;
         gxTv_SdtSYS_Role_Sys_roledescription = "";
         return  ;
      }

      public bool gxTv_SdtSYS_Role_Sys_roledescription_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_RoleCreator" )]
      [  XmlElement( ElementName = "SYS_RoleCreator"   )]
      public String gxTpr_Sys_rolecreator
      {
         get {
            return gxTv_SdtSYS_Role_Sys_rolecreator ;
         }

         set {
            gxTv_SdtSYS_Role_Sys_rolecreator = value;
            SetDirty("Sys_rolecreator");
         }

      }

      [  SoapElement( ElementName = "SYS_RoleCreateTime" )]
      [  XmlElement( ElementName = "SYS_RoleCreateTime"  , IsNullable=true )]
      public string gxTpr_Sys_rolecreatetime_Nullable
      {
         get {
            if ( gxTv_SdtSYS_Role_Sys_rolecreatetime == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtSYS_Role_Sys_rolecreatetime).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtSYS_Role_Sys_rolecreatetime = DateTime.MinValue;
            else
               gxTv_SdtSYS_Role_Sys_rolecreatetime = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Sys_rolecreatetime
      {
         get {
            return gxTv_SdtSYS_Role_Sys_rolecreatetime ;
         }

         set {
            gxTv_SdtSYS_Role_Sys_rolecreatetime = value;
            SetDirty("Sys_rolecreatetime");
         }

      }

      [  SoapElement( ElementName = "SYS_RoleModifier" )]
      [  XmlElement( ElementName = "SYS_RoleModifier"   )]
      public String gxTpr_Sys_rolemodifier
      {
         get {
            return gxTv_SdtSYS_Role_Sys_rolemodifier ;
         }

         set {
            gxTv_SdtSYS_Role_Sys_rolemodifier_N = 0;
            gxTv_SdtSYS_Role_Sys_rolemodifier = value;
            SetDirty("Sys_rolemodifier");
         }

      }

      public void gxTv_SdtSYS_Role_Sys_rolemodifier_SetNull( )
      {
         gxTv_SdtSYS_Role_Sys_rolemodifier_N = 1;
         gxTv_SdtSYS_Role_Sys_rolemodifier = "";
         return  ;
      }

      public bool gxTv_SdtSYS_Role_Sys_rolemodifier_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_RoleModifyTime" )]
      [  XmlElement( ElementName = "SYS_RoleModifyTime"  , IsNullable=true )]
      public string gxTpr_Sys_rolemodifytime_Nullable
      {
         get {
            if ( gxTv_SdtSYS_Role_Sys_rolemodifytime == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtSYS_Role_Sys_rolemodifytime).value ;
         }

         set {
            gxTv_SdtSYS_Role_Sys_rolemodifytime_N = 0;
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtSYS_Role_Sys_rolemodifytime = DateTime.MinValue;
            else
               gxTv_SdtSYS_Role_Sys_rolemodifytime = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Sys_rolemodifytime
      {
         get {
            return gxTv_SdtSYS_Role_Sys_rolemodifytime ;
         }

         set {
            gxTv_SdtSYS_Role_Sys_rolemodifytime_N = 0;
            gxTv_SdtSYS_Role_Sys_rolemodifytime = value;
            SetDirty("Sys_rolemodifytime");
         }

      }

      public void gxTv_SdtSYS_Role_Sys_rolemodifytime_SetNull( )
      {
         gxTv_SdtSYS_Role_Sys_rolemodifytime_N = 1;
         gxTv_SdtSYS_Role_Sys_rolemodifytime = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtSYS_Role_Sys_rolemodifytime_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_RoleIsDeleted" )]
      [  XmlElement( ElementName = "SYS_RoleIsDeleted"   )]
      public short gxTpr_Sys_roleisdeleted
      {
         get {
            return gxTv_SdtSYS_Role_Sys_roleisdeleted ;
         }

         set {
            gxTv_SdtSYS_Role_Sys_roleisdeleted = value;
            SetDirty("Sys_roleisdeleted");
         }

      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtSYS_Role_Mode ;
         }

         set {
            gxTv_SdtSYS_Role_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtSYS_Role_Mode_SetNull( )
      {
         gxTv_SdtSYS_Role_Mode = "";
         return  ;
      }

      public bool gxTv_SdtSYS_Role_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtSYS_Role_Initialized ;
         }

         set {
            gxTv_SdtSYS_Role_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtSYS_Role_Initialized_SetNull( )
      {
         gxTv_SdtSYS_Role_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtSYS_Role_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "RoleID_Z" )]
      [  XmlElement( ElementName = "RoleID_Z"   )]
      public Guid gxTpr_Roleid_Z
      {
         get {
            return gxTv_SdtSYS_Role_Roleid_Z ;
         }

         set {
            gxTv_SdtSYS_Role_Roleid_Z = (Guid)(value);
            SetDirty("Roleid_Z");
         }

      }

      public void gxTv_SdtSYS_Role_Roleid_Z_SetNull( )
      {
         gxTv_SdtSYS_Role_Roleid_Z = (Guid)(Guid.Empty);
         return  ;
      }

      public bool gxTv_SdtSYS_Role_Roleid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_RoleTenantCode_Z" )]
      [  XmlElement( ElementName = "SYS_RoleTenantCode_Z"   )]
      public String gxTpr_Sys_roletenantcode_Z
      {
         get {
            return gxTv_SdtSYS_Role_Sys_roletenantcode_Z ;
         }

         set {
            gxTv_SdtSYS_Role_Sys_roletenantcode_Z = value;
            SetDirty("Sys_roletenantcode_Z");
         }

      }

      public void gxTv_SdtSYS_Role_Sys_roletenantcode_Z_SetNull( )
      {
         gxTv_SdtSYS_Role_Sys_roletenantcode_Z = "";
         return  ;
      }

      public bool gxTv_SdtSYS_Role_Sys_roletenantcode_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "RoleName_Z" )]
      [  XmlElement( ElementName = "RoleName_Z"   )]
      public String gxTpr_Rolename_Z
      {
         get {
            return gxTv_SdtSYS_Role_Rolename_Z ;
         }

         set {
            gxTv_SdtSYS_Role_Rolename_Z = value;
            SetDirty("Rolename_Z");
         }

      }

      public void gxTv_SdtSYS_Role_Rolename_Z_SetNull( )
      {
         gxTv_SdtSYS_Role_Rolename_Z = "";
         return  ;
      }

      public bool gxTv_SdtSYS_Role_Rolename_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "RoleType_Z" )]
      [  XmlElement( ElementName = "RoleType_Z"   )]
      public int gxTpr_Roletype_Z
      {
         get {
            return gxTv_SdtSYS_Role_Roletype_Z ;
         }

         set {
            gxTv_SdtSYS_Role_Roletype_Z = value;
            SetDirty("Roletype_Z");
         }

      }

      public void gxTv_SdtSYS_Role_Roletype_Z_SetNull( )
      {
         gxTv_SdtSYS_Role_Roletype_Z = 0;
         return  ;
      }

      public bool gxTv_SdtSYS_Role_Roletype_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_RoleCreator_Z" )]
      [  XmlElement( ElementName = "SYS_RoleCreator_Z"   )]
      public String gxTpr_Sys_rolecreator_Z
      {
         get {
            return gxTv_SdtSYS_Role_Sys_rolecreator_Z ;
         }

         set {
            gxTv_SdtSYS_Role_Sys_rolecreator_Z = value;
            SetDirty("Sys_rolecreator_Z");
         }

      }

      public void gxTv_SdtSYS_Role_Sys_rolecreator_Z_SetNull( )
      {
         gxTv_SdtSYS_Role_Sys_rolecreator_Z = "";
         return  ;
      }

      public bool gxTv_SdtSYS_Role_Sys_rolecreator_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_RoleCreateTime_Z" )]
      [  XmlElement( ElementName = "SYS_RoleCreateTime_Z"  , IsNullable=true )]
      public string gxTpr_Sys_rolecreatetime_Z_Nullable
      {
         get {
            if ( gxTv_SdtSYS_Role_Sys_rolecreatetime_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtSYS_Role_Sys_rolecreatetime_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtSYS_Role_Sys_rolecreatetime_Z = DateTime.MinValue;
            else
               gxTv_SdtSYS_Role_Sys_rolecreatetime_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Sys_rolecreatetime_Z
      {
         get {
            return gxTv_SdtSYS_Role_Sys_rolecreatetime_Z ;
         }

         set {
            gxTv_SdtSYS_Role_Sys_rolecreatetime_Z = value;
            SetDirty("Sys_rolecreatetime_Z");
         }

      }

      public void gxTv_SdtSYS_Role_Sys_rolecreatetime_Z_SetNull( )
      {
         gxTv_SdtSYS_Role_Sys_rolecreatetime_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtSYS_Role_Sys_rolecreatetime_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_RoleModifier_Z" )]
      [  XmlElement( ElementName = "SYS_RoleModifier_Z"   )]
      public String gxTpr_Sys_rolemodifier_Z
      {
         get {
            return gxTv_SdtSYS_Role_Sys_rolemodifier_Z ;
         }

         set {
            gxTv_SdtSYS_Role_Sys_rolemodifier_Z = value;
            SetDirty("Sys_rolemodifier_Z");
         }

      }

      public void gxTv_SdtSYS_Role_Sys_rolemodifier_Z_SetNull( )
      {
         gxTv_SdtSYS_Role_Sys_rolemodifier_Z = "";
         return  ;
      }

      public bool gxTv_SdtSYS_Role_Sys_rolemodifier_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_RoleModifyTime_Z" )]
      [  XmlElement( ElementName = "SYS_RoleModifyTime_Z"  , IsNullable=true )]
      public string gxTpr_Sys_rolemodifytime_Z_Nullable
      {
         get {
            if ( gxTv_SdtSYS_Role_Sys_rolemodifytime_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtSYS_Role_Sys_rolemodifytime_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtSYS_Role_Sys_rolemodifytime_Z = DateTime.MinValue;
            else
               gxTv_SdtSYS_Role_Sys_rolemodifytime_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Sys_rolemodifytime_Z
      {
         get {
            return gxTv_SdtSYS_Role_Sys_rolemodifytime_Z ;
         }

         set {
            gxTv_SdtSYS_Role_Sys_rolemodifytime_Z = value;
            SetDirty("Sys_rolemodifytime_Z");
         }

      }

      public void gxTv_SdtSYS_Role_Sys_rolemodifytime_Z_SetNull( )
      {
         gxTv_SdtSYS_Role_Sys_rolemodifytime_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtSYS_Role_Sys_rolemodifytime_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_RoleIsDeleted_Z" )]
      [  XmlElement( ElementName = "SYS_RoleIsDeleted_Z"   )]
      public short gxTpr_Sys_roleisdeleted_Z
      {
         get {
            return gxTv_SdtSYS_Role_Sys_roleisdeleted_Z ;
         }

         set {
            gxTv_SdtSYS_Role_Sys_roleisdeleted_Z = value;
            SetDirty("Sys_roleisdeleted_Z");
         }

      }

      public void gxTv_SdtSYS_Role_Sys_roleisdeleted_Z_SetNull( )
      {
         gxTv_SdtSYS_Role_Sys_roleisdeleted_Z = 0;
         return  ;
      }

      public bool gxTv_SdtSYS_Role_Sys_roleisdeleted_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_RoleTenantCode_N" )]
      [  XmlElement( ElementName = "SYS_RoleTenantCode_N"   )]
      public short gxTpr_Sys_roletenantcode_N
      {
         get {
            return gxTv_SdtSYS_Role_Sys_roletenantcode_N ;
         }

         set {
            gxTv_SdtSYS_Role_Sys_roletenantcode_N = value;
            SetDirty("Sys_roletenantcode_N");
         }

      }

      public void gxTv_SdtSYS_Role_Sys_roletenantcode_N_SetNull( )
      {
         gxTv_SdtSYS_Role_Sys_roletenantcode_N = 0;
         return  ;
      }

      public bool gxTv_SdtSYS_Role_Sys_roletenantcode_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_RoleDescription_N" )]
      [  XmlElement( ElementName = "SYS_RoleDescription_N"   )]
      public short gxTpr_Sys_roledescription_N
      {
         get {
            return gxTv_SdtSYS_Role_Sys_roledescription_N ;
         }

         set {
            gxTv_SdtSYS_Role_Sys_roledescription_N = value;
            SetDirty("Sys_roledescription_N");
         }

      }

      public void gxTv_SdtSYS_Role_Sys_roledescription_N_SetNull( )
      {
         gxTv_SdtSYS_Role_Sys_roledescription_N = 0;
         return  ;
      }

      public bool gxTv_SdtSYS_Role_Sys_roledescription_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_RoleModifier_N" )]
      [  XmlElement( ElementName = "SYS_RoleModifier_N"   )]
      public short gxTpr_Sys_rolemodifier_N
      {
         get {
            return gxTv_SdtSYS_Role_Sys_rolemodifier_N ;
         }

         set {
            gxTv_SdtSYS_Role_Sys_rolemodifier_N = value;
            SetDirty("Sys_rolemodifier_N");
         }

      }

      public void gxTv_SdtSYS_Role_Sys_rolemodifier_N_SetNull( )
      {
         gxTv_SdtSYS_Role_Sys_rolemodifier_N = 0;
         return  ;
      }

      public bool gxTv_SdtSYS_Role_Sys_rolemodifier_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_RoleModifyTime_N" )]
      [  XmlElement( ElementName = "SYS_RoleModifyTime_N"   )]
      public short gxTpr_Sys_rolemodifytime_N
      {
         get {
            return gxTv_SdtSYS_Role_Sys_rolemodifytime_N ;
         }

         set {
            gxTv_SdtSYS_Role_Sys_rolemodifytime_N = value;
            SetDirty("Sys_rolemodifytime_N");
         }

      }

      public void gxTv_SdtSYS_Role_Sys_rolemodifytime_N_SetNull( )
      {
         gxTv_SdtSYS_Role_Sys_rolemodifytime_N = 0;
         return  ;
      }

      public bool gxTv_SdtSYS_Role_Sys_rolemodifytime_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtSYS_Role_Roleid = (Guid)(Guid.Empty);
         gxTv_SdtSYS_Role_Sys_roletenantcode = "";
         gxTv_SdtSYS_Role_Rolename = "";
         gxTv_SdtSYS_Role_Sys_roledescription = "";
         gxTv_SdtSYS_Role_Sys_rolecreator = "";
         gxTv_SdtSYS_Role_Sys_rolecreatetime = (DateTime)(DateTime.MinValue);
         gxTv_SdtSYS_Role_Sys_rolemodifier = "";
         gxTv_SdtSYS_Role_Sys_rolemodifytime = (DateTime)(DateTime.MinValue);
         gxTv_SdtSYS_Role_Mode = "";
         gxTv_SdtSYS_Role_Roleid_Z = (Guid)(Guid.Empty);
         gxTv_SdtSYS_Role_Sys_roletenantcode_Z = "";
         gxTv_SdtSYS_Role_Rolename_Z = "";
         gxTv_SdtSYS_Role_Sys_rolecreator_Z = "";
         gxTv_SdtSYS_Role_Sys_rolecreatetime_Z = (DateTime)(DateTime.MinValue);
         gxTv_SdtSYS_Role_Sys_rolemodifier_Z = "";
         gxTv_SdtSYS_Role_Sys_rolemodifytime_Z = (DateTime)(DateTime.MinValue);
         datetime_STZ = (DateTime)(DateTime.MinValue);
         sDateCnv = "";
         sNumToPad = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "sys_role", "GeneXus.Programs.sys_role_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtSYS_Role_Sys_roleisdeleted ;
      private short gxTv_SdtSYS_Role_Initialized ;
      private short gxTv_SdtSYS_Role_Sys_roleisdeleted_Z ;
      private short gxTv_SdtSYS_Role_Sys_roletenantcode_N ;
      private short gxTv_SdtSYS_Role_Sys_roledescription_N ;
      private short gxTv_SdtSYS_Role_Sys_rolemodifier_N ;
      private short gxTv_SdtSYS_Role_Sys_rolemodifytime_N ;
      private int gxTv_SdtSYS_Role_Roletype ;
      private int gxTv_SdtSYS_Role_Roletype_Z ;
      private String gxTv_SdtSYS_Role_Mode ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_SdtSYS_Role_Sys_rolecreatetime ;
      private DateTime gxTv_SdtSYS_Role_Sys_rolemodifytime ;
      private DateTime gxTv_SdtSYS_Role_Sys_rolecreatetime_Z ;
      private DateTime gxTv_SdtSYS_Role_Sys_rolemodifytime_Z ;
      private DateTime datetime_STZ ;
      private String gxTv_SdtSYS_Role_Sys_roledescription ;
      private String gxTv_SdtSYS_Role_Sys_roletenantcode ;
      private String gxTv_SdtSYS_Role_Rolename ;
      private String gxTv_SdtSYS_Role_Sys_rolecreator ;
      private String gxTv_SdtSYS_Role_Sys_rolemodifier ;
      private String gxTv_SdtSYS_Role_Sys_roletenantcode_Z ;
      private String gxTv_SdtSYS_Role_Rolename_Z ;
      private String gxTv_SdtSYS_Role_Sys_rolecreator_Z ;
      private String gxTv_SdtSYS_Role_Sys_rolemodifier_Z ;
      private Guid gxTv_SdtSYS_Role_Roleid ;
      private Guid gxTv_SdtSYS_Role_Roleid_Z ;
   }

   [DataContract(Name = @"SYS_Role", Namespace = "DataAnalysisPlatform")]
   public class SdtSYS_Role_RESTInterface : GxGenericCollectionItem<SdtSYS_Role>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSYS_Role_RESTInterface( ) : base()
      {
      }

      public SdtSYS_Role_RESTInterface( SdtSYS_Role psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "RoleID" , Order = 0 )]
      [GxSeudo()]
      public Guid gxTpr_Roleid
      {
         get {
            return sdt.gxTpr_Roleid ;
         }

         set {
            sdt.gxTpr_Roleid = (Guid)(value);
         }

      }

      [DataMember( Name = "SYS_RoleTenantCode" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Sys_roletenantcode
      {
         get {
            return sdt.gxTpr_Sys_roletenantcode ;
         }

         set {
            sdt.gxTpr_Sys_roletenantcode = value;
         }

      }

      [DataMember( Name = "RoleName" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Rolename
      {
         get {
            return sdt.gxTpr_Rolename ;
         }

         set {
            sdt.gxTpr_Rolename = value;
         }

      }

      [DataMember( Name = "RoleType" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Roletype
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Roletype), 9, 0)) ;
         }

         set {
            sdt.gxTpr_Roletype = (int)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "SYS_RoleDescription" , Order = 4 )]
      public String gxTpr_Sys_roledescription
      {
         get {
            return sdt.gxTpr_Sys_roledescription ;
         }

         set {
            sdt.gxTpr_Sys_roledescription = value;
         }

      }

      [DataMember( Name = "SYS_RoleCreator" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Sys_rolecreator
      {
         get {
            return sdt.gxTpr_Sys_rolecreator ;
         }

         set {
            sdt.gxTpr_Sys_rolecreator = value;
         }

      }

      [DataMember( Name = "SYS_RoleCreateTime" , Order = 6 )]
      [GxSeudo()]
      public String gxTpr_Sys_rolecreatetime
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Sys_rolecreatetime) ;
         }

         set {
            sdt.gxTpr_Sys_rolecreatetime = DateTimeUtil.CToT2( value);
         }

      }

      [DataMember( Name = "SYS_RoleModifier" , Order = 7 )]
      [GxSeudo()]
      public String gxTpr_Sys_rolemodifier
      {
         get {
            return sdt.gxTpr_Sys_rolemodifier ;
         }

         set {
            sdt.gxTpr_Sys_rolemodifier = value;
         }

      }

      [DataMember( Name = "SYS_RoleModifyTime" , Order = 8 )]
      [GxSeudo()]
      public String gxTpr_Sys_rolemodifytime
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Sys_rolemodifytime) ;
         }

         set {
            sdt.gxTpr_Sys_rolemodifytime = DateTimeUtil.CToT2( value);
         }

      }

      [DataMember( Name = "SYS_RoleIsDeleted" , Order = 9 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Sys_roleisdeleted
      {
         get {
            return sdt.gxTpr_Sys_roleisdeleted ;
         }

         set {
            sdt.gxTpr_Sys_roleisdeleted = (short)(value.HasValue ? value.Value : 0);
         }

      }

      public SdtSYS_Role sdt
      {
         get {
            return (SdtSYS_Role)Sdt ;
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
            sdt = new SdtSYS_Role() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 10 )]
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

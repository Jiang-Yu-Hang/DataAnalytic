/*
               File: type_SdtBAS_Tenant
        Description: BAS_Tenant
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:38:59.55
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
   [XmlRoot(ElementName = "BAS_Tenant" )]
   [XmlType(TypeName =  "BAS_Tenant" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtBAS_Tenant : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBAS_Tenant( )
      {
      }

      public SdtBAS_Tenant( IGxContext context )
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

      public void Load( String AV360BAS_TenantTenantCode )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(String)AV360BAS_TenantTenantCode});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"BAS_TenantTenantCode", typeof(String)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "BAS_Tenant");
         metadata.Set("BT", "BAS_TENANT");
         metadata.Set("PK", "[ \"BAS_TenantTenantCode\" ]");
         metadata.Set("FKList", "[ { \"FK\":[ \"DatabaseID\" ],\"FKMap\":[  ] },{ \"FK\":[ \"InstituteCode\" ],\"FKMap\":[  ] } ]");
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
         state.Add("gxTpr_Bas_tenanttenantcode_Z");
         state.Add("gxTpr_Tenantname_Z");
         state.Add("gxTpr_Institutecode_Z");
         state.Add("gxTpr_Hospitalname_Z");
         state.Add("gxTpr_Databaseid_Z");
         state.Add("gxTpr_Bas_tenantcreator_Z");
         state.Add("gxTpr_Bas_tenantcreatetime_Z_Nullable");
         state.Add("gxTpr_Bas_tenantmodifier_Z");
         state.Add("gxTpr_Bas_tenantmodifytime_Z_Nullable");
         state.Add("gxTpr_Bas_tenantisdeleted_Z");
         state.Add("gxTpr_Institutecode_N");
         state.Add("gxTpr_Bas_tenantlogo_N");
         state.Add("gxTpr_Bas_tenantmodifier_N");
         state.Add("gxTpr_Bas_tenantmodifytime_N");
         state.Add("gxTpr_Bas_tenantdescription_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtBAS_Tenant sdt ;
         sdt = (SdtBAS_Tenant)(source);
         gxTv_SdtBAS_Tenant_Bas_tenanttenantcode = sdt.gxTv_SdtBAS_Tenant_Bas_tenanttenantcode ;
         gxTv_SdtBAS_Tenant_Tenantname = sdt.gxTv_SdtBAS_Tenant_Tenantname ;
         gxTv_SdtBAS_Tenant_Institutecode = sdt.gxTv_SdtBAS_Tenant_Institutecode ;
         gxTv_SdtBAS_Tenant_Hospitalname = sdt.gxTv_SdtBAS_Tenant_Hospitalname ;
         gxTv_SdtBAS_Tenant_Databaseid = sdt.gxTv_SdtBAS_Tenant_Databaseid ;
         gxTv_SdtBAS_Tenant_Bas_tenantlogo = sdt.gxTv_SdtBAS_Tenant_Bas_tenantlogo ;
         gxTv_SdtBAS_Tenant_Bas_tenantcreator = sdt.gxTv_SdtBAS_Tenant_Bas_tenantcreator ;
         gxTv_SdtBAS_Tenant_Bas_tenantcreatetime = sdt.gxTv_SdtBAS_Tenant_Bas_tenantcreatetime ;
         gxTv_SdtBAS_Tenant_Bas_tenantmodifier = sdt.gxTv_SdtBAS_Tenant_Bas_tenantmodifier ;
         gxTv_SdtBAS_Tenant_Bas_tenantmodifytime = sdt.gxTv_SdtBAS_Tenant_Bas_tenantmodifytime ;
         gxTv_SdtBAS_Tenant_Bas_tenantisdeleted = sdt.gxTv_SdtBAS_Tenant_Bas_tenantisdeleted ;
         gxTv_SdtBAS_Tenant_Bas_tenantdescription = sdt.gxTv_SdtBAS_Tenant_Bas_tenantdescription ;
         gxTv_SdtBAS_Tenant_Mode = sdt.gxTv_SdtBAS_Tenant_Mode ;
         gxTv_SdtBAS_Tenant_Initialized = sdt.gxTv_SdtBAS_Tenant_Initialized ;
         gxTv_SdtBAS_Tenant_Bas_tenanttenantcode_Z = sdt.gxTv_SdtBAS_Tenant_Bas_tenanttenantcode_Z ;
         gxTv_SdtBAS_Tenant_Tenantname_Z = sdt.gxTv_SdtBAS_Tenant_Tenantname_Z ;
         gxTv_SdtBAS_Tenant_Institutecode_Z = sdt.gxTv_SdtBAS_Tenant_Institutecode_Z ;
         gxTv_SdtBAS_Tenant_Hospitalname_Z = sdt.gxTv_SdtBAS_Tenant_Hospitalname_Z ;
         gxTv_SdtBAS_Tenant_Databaseid_Z = sdt.gxTv_SdtBAS_Tenant_Databaseid_Z ;
         gxTv_SdtBAS_Tenant_Bas_tenantcreator_Z = sdt.gxTv_SdtBAS_Tenant_Bas_tenantcreator_Z ;
         gxTv_SdtBAS_Tenant_Bas_tenantcreatetime_Z = sdt.gxTv_SdtBAS_Tenant_Bas_tenantcreatetime_Z ;
         gxTv_SdtBAS_Tenant_Bas_tenantmodifier_Z = sdt.gxTv_SdtBAS_Tenant_Bas_tenantmodifier_Z ;
         gxTv_SdtBAS_Tenant_Bas_tenantmodifytime_Z = sdt.gxTv_SdtBAS_Tenant_Bas_tenantmodifytime_Z ;
         gxTv_SdtBAS_Tenant_Bas_tenantisdeleted_Z = sdt.gxTv_SdtBAS_Tenant_Bas_tenantisdeleted_Z ;
         gxTv_SdtBAS_Tenant_Institutecode_N = sdt.gxTv_SdtBAS_Tenant_Institutecode_N ;
         gxTv_SdtBAS_Tenant_Bas_tenantlogo_N = sdt.gxTv_SdtBAS_Tenant_Bas_tenantlogo_N ;
         gxTv_SdtBAS_Tenant_Bas_tenantmodifier_N = sdt.gxTv_SdtBAS_Tenant_Bas_tenantmodifier_N ;
         gxTv_SdtBAS_Tenant_Bas_tenantmodifytime_N = sdt.gxTv_SdtBAS_Tenant_Bas_tenantmodifytime_N ;
         gxTv_SdtBAS_Tenant_Bas_tenantdescription_N = sdt.gxTv_SdtBAS_Tenant_Bas_tenantdescription_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("BAS_TenantTenantCode", gxTv_SdtBAS_Tenant_Bas_tenanttenantcode, false);
         AddObjectProperty("TenantName", gxTv_SdtBAS_Tenant_Tenantname, false);
         AddObjectProperty("InstituteCode", gxTv_SdtBAS_Tenant_Institutecode, false);
         AddObjectProperty("InstituteCode_N", gxTv_SdtBAS_Tenant_Institutecode_N, false);
         AddObjectProperty("HospitalName", gxTv_SdtBAS_Tenant_Hospitalname, false);
         AddObjectProperty("DatabaseID", gxTv_SdtBAS_Tenant_Databaseid, false);
         AddObjectProperty("BAS_TenantLogo", gxTv_SdtBAS_Tenant_Bas_tenantlogo, false);
         AddObjectProperty("BAS_TenantLogo_N", gxTv_SdtBAS_Tenant_Bas_tenantlogo_N, false);
         AddObjectProperty("BAS_TenantCreator", gxTv_SdtBAS_Tenant_Bas_tenantcreator, false);
         datetime_STZ = gxTv_SdtBAS_Tenant_Bas_tenantcreatetime;
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
         AddObjectProperty("BAS_TenantCreateTime", sDateCnv, false);
         AddObjectProperty("BAS_TenantModifier", gxTv_SdtBAS_Tenant_Bas_tenantmodifier, false);
         AddObjectProperty("BAS_TenantModifier_N", gxTv_SdtBAS_Tenant_Bas_tenantmodifier_N, false);
         datetime_STZ = gxTv_SdtBAS_Tenant_Bas_tenantmodifytime;
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
         AddObjectProperty("BAS_TenantModifyTime", sDateCnv, false);
         AddObjectProperty("BAS_TenantModifyTime_N", gxTv_SdtBAS_Tenant_Bas_tenantmodifytime_N, false);
         AddObjectProperty("BAS_TenantIsDeleted", gxTv_SdtBAS_Tenant_Bas_tenantisdeleted, false);
         AddObjectProperty("BAS_TenantDescription", gxTv_SdtBAS_Tenant_Bas_tenantdescription, false);
         AddObjectProperty("BAS_TenantDescription_N", gxTv_SdtBAS_Tenant_Bas_tenantdescription_N, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtBAS_Tenant_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtBAS_Tenant_Initialized, false);
            AddObjectProperty("BAS_TenantTenantCode_Z", gxTv_SdtBAS_Tenant_Bas_tenanttenantcode_Z, false);
            AddObjectProperty("TenantName_Z", gxTv_SdtBAS_Tenant_Tenantname_Z, false);
            AddObjectProperty("InstituteCode_Z", gxTv_SdtBAS_Tenant_Institutecode_Z, false);
            AddObjectProperty("HospitalName_Z", gxTv_SdtBAS_Tenant_Hospitalname_Z, false);
            AddObjectProperty("DatabaseID_Z", gxTv_SdtBAS_Tenant_Databaseid_Z, false);
            AddObjectProperty("BAS_TenantCreator_Z", gxTv_SdtBAS_Tenant_Bas_tenantcreator_Z, false);
            datetime_STZ = gxTv_SdtBAS_Tenant_Bas_tenantcreatetime_Z;
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
            AddObjectProperty("BAS_TenantCreateTime_Z", sDateCnv, false);
            AddObjectProperty("BAS_TenantModifier_Z", gxTv_SdtBAS_Tenant_Bas_tenantmodifier_Z, false);
            datetime_STZ = gxTv_SdtBAS_Tenant_Bas_tenantmodifytime_Z;
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
            AddObjectProperty("BAS_TenantModifyTime_Z", sDateCnv, false);
            AddObjectProperty("BAS_TenantIsDeleted_Z", gxTv_SdtBAS_Tenant_Bas_tenantisdeleted_Z, false);
            AddObjectProperty("InstituteCode_N", gxTv_SdtBAS_Tenant_Institutecode_N, false);
            AddObjectProperty("BAS_TenantLogo_N", gxTv_SdtBAS_Tenant_Bas_tenantlogo_N, false);
            AddObjectProperty("BAS_TenantModifier_N", gxTv_SdtBAS_Tenant_Bas_tenantmodifier_N, false);
            AddObjectProperty("BAS_TenantModifyTime_N", gxTv_SdtBAS_Tenant_Bas_tenantmodifytime_N, false);
            AddObjectProperty("BAS_TenantDescription_N", gxTv_SdtBAS_Tenant_Bas_tenantdescription_N, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtBAS_Tenant sdt )
      {
         if ( sdt.IsDirty("BAS_TenantTenantCode") )
         {
            gxTv_SdtBAS_Tenant_Bas_tenanttenantcode = sdt.gxTv_SdtBAS_Tenant_Bas_tenanttenantcode ;
         }
         if ( sdt.IsDirty("TenantName") )
         {
            gxTv_SdtBAS_Tenant_Tenantname = sdt.gxTv_SdtBAS_Tenant_Tenantname ;
         }
         if ( sdt.IsDirty("InstituteCode") )
         {
            gxTv_SdtBAS_Tenant_Institutecode = sdt.gxTv_SdtBAS_Tenant_Institutecode ;
         }
         if ( sdt.IsDirty("HospitalName") )
         {
            gxTv_SdtBAS_Tenant_Hospitalname = sdt.gxTv_SdtBAS_Tenant_Hospitalname ;
         }
         if ( sdt.IsDirty("DatabaseID") )
         {
            gxTv_SdtBAS_Tenant_Databaseid = sdt.gxTv_SdtBAS_Tenant_Databaseid ;
         }
         if ( sdt.IsDirty("BAS_TenantLogo") )
         {
            gxTv_SdtBAS_Tenant_Bas_tenantlogo = sdt.gxTv_SdtBAS_Tenant_Bas_tenantlogo ;
         }
         if ( sdt.IsDirty("BAS_TenantCreator") )
         {
            gxTv_SdtBAS_Tenant_Bas_tenantcreator = sdt.gxTv_SdtBAS_Tenant_Bas_tenantcreator ;
         }
         if ( sdt.IsDirty("BAS_TenantCreateTime") )
         {
            gxTv_SdtBAS_Tenant_Bas_tenantcreatetime = sdt.gxTv_SdtBAS_Tenant_Bas_tenantcreatetime ;
         }
         if ( sdt.IsDirty("BAS_TenantModifier") )
         {
            gxTv_SdtBAS_Tenant_Bas_tenantmodifier = sdt.gxTv_SdtBAS_Tenant_Bas_tenantmodifier ;
         }
         if ( sdt.IsDirty("BAS_TenantModifyTime") )
         {
            gxTv_SdtBAS_Tenant_Bas_tenantmodifytime = sdt.gxTv_SdtBAS_Tenant_Bas_tenantmodifytime ;
         }
         if ( sdt.IsDirty("BAS_TenantIsDeleted") )
         {
            gxTv_SdtBAS_Tenant_Bas_tenantisdeleted = sdt.gxTv_SdtBAS_Tenant_Bas_tenantisdeleted ;
         }
         if ( sdt.IsDirty("BAS_TenantDescription") )
         {
            gxTv_SdtBAS_Tenant_Bas_tenantdescription = sdt.gxTv_SdtBAS_Tenant_Bas_tenantdescription ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "BAS_TenantTenantCode" )]
      [  XmlElement( ElementName = "BAS_TenantTenantCode"   )]
      public String gxTpr_Bas_tenanttenantcode
      {
         get {
            return gxTv_SdtBAS_Tenant_Bas_tenanttenantcode ;
         }

         set {
            if ( StringUtil.StrCmp(gxTv_SdtBAS_Tenant_Bas_tenanttenantcode, value) != 0 )
            {
               gxTv_SdtBAS_Tenant_Mode = "INS";
               this.gxTv_SdtBAS_Tenant_Bas_tenanttenantcode_Z_SetNull( );
               this.gxTv_SdtBAS_Tenant_Tenantname_Z_SetNull( );
               this.gxTv_SdtBAS_Tenant_Institutecode_Z_SetNull( );
               this.gxTv_SdtBAS_Tenant_Hospitalname_Z_SetNull( );
               this.gxTv_SdtBAS_Tenant_Databaseid_Z_SetNull( );
               this.gxTv_SdtBAS_Tenant_Bas_tenantcreator_Z_SetNull( );
               this.gxTv_SdtBAS_Tenant_Bas_tenantcreatetime_Z_SetNull( );
               this.gxTv_SdtBAS_Tenant_Bas_tenantmodifier_Z_SetNull( );
               this.gxTv_SdtBAS_Tenant_Bas_tenantmodifytime_Z_SetNull( );
               this.gxTv_SdtBAS_Tenant_Bas_tenantisdeleted_Z_SetNull( );
            }
            gxTv_SdtBAS_Tenant_Bas_tenanttenantcode = value;
            SetDirty("Bas_tenanttenantcode");
         }

      }

      [  SoapElement( ElementName = "TenantName" )]
      [  XmlElement( ElementName = "TenantName"   )]
      public String gxTpr_Tenantname
      {
         get {
            return gxTv_SdtBAS_Tenant_Tenantname ;
         }

         set {
            gxTv_SdtBAS_Tenant_Tenantname = value;
            SetDirty("Tenantname");
         }

      }

      [  SoapElement( ElementName = "InstituteCode" )]
      [  XmlElement( ElementName = "InstituteCode"   )]
      public String gxTpr_Institutecode
      {
         get {
            return gxTv_SdtBAS_Tenant_Institutecode ;
         }

         set {
            gxTv_SdtBAS_Tenant_Institutecode_N = 0;
            gxTv_SdtBAS_Tenant_Institutecode = value;
            SetDirty("Institutecode");
         }

      }

      public void gxTv_SdtBAS_Tenant_Institutecode_SetNull( )
      {
         gxTv_SdtBAS_Tenant_Institutecode_N = 1;
         gxTv_SdtBAS_Tenant_Institutecode = "";
         return  ;
      }

      public bool gxTv_SdtBAS_Tenant_Institutecode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "HospitalName" )]
      [  XmlElement( ElementName = "HospitalName"   )]
      public String gxTpr_Hospitalname
      {
         get {
            return gxTv_SdtBAS_Tenant_Hospitalname ;
         }

         set {
            gxTv_SdtBAS_Tenant_Hospitalname = value;
            SetDirty("Hospitalname");
         }

      }

      [  SoapElement( ElementName = "DatabaseID" )]
      [  XmlElement( ElementName = "DatabaseID"   )]
      public int gxTpr_Databaseid
      {
         get {
            return gxTv_SdtBAS_Tenant_Databaseid ;
         }

         set {
            gxTv_SdtBAS_Tenant_Databaseid = value;
            SetDirty("Databaseid");
         }

      }

      [  SoapElement( ElementName = "BAS_TenantLogo" )]
      [  XmlElement( ElementName = "BAS_TenantLogo"   )]
      [GxUpload()]
      public byte[] gxTpr_Bas_tenantlogo_Blob
      {
         get {
            IGxContext context = this.context == null ? new GxContext() : this.context;
            return context.FileToByteArray( gxTv_SdtBAS_Tenant_Bas_tenantlogo) ;
         }

         set {
            gxTv_SdtBAS_Tenant_Bas_tenantlogo_N = 0;
            IGxContext context = this.context == null ? new GxContext() : this.context;
            gxTv_SdtBAS_Tenant_Bas_tenantlogo=context.FileFromByteArray( value) ;
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      [GxUpload()]
      public String gxTpr_Bas_tenantlogo
      {
         get {
            return gxTv_SdtBAS_Tenant_Bas_tenantlogo ;
         }

         set {
            gxTv_SdtBAS_Tenant_Bas_tenantlogo_N = 0;
            gxTv_SdtBAS_Tenant_Bas_tenantlogo = value;
            SetDirty("Bas_tenantlogo");
         }

      }

      public void gxTv_SdtBAS_Tenant_Bas_tenantlogo_SetBlob( String blob ,
                                                             String fileName ,
                                                             String fileType )
      {
         gxTv_SdtBAS_Tenant_Bas_tenantlogo = blob;
         return  ;
      }

      public void gxTv_SdtBAS_Tenant_Bas_tenantlogo_SetNull( )
      {
         gxTv_SdtBAS_Tenant_Bas_tenantlogo_N = 1;
         gxTv_SdtBAS_Tenant_Bas_tenantlogo = "";
         return  ;
      }

      public bool gxTv_SdtBAS_Tenant_Bas_tenantlogo_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BAS_TenantCreator" )]
      [  XmlElement( ElementName = "BAS_TenantCreator"   )]
      public String gxTpr_Bas_tenantcreator
      {
         get {
            return gxTv_SdtBAS_Tenant_Bas_tenantcreator ;
         }

         set {
            gxTv_SdtBAS_Tenant_Bas_tenantcreator = value;
            SetDirty("Bas_tenantcreator");
         }

      }

      [  SoapElement( ElementName = "BAS_TenantCreateTime" )]
      [  XmlElement( ElementName = "BAS_TenantCreateTime"  , IsNullable=true )]
      public string gxTpr_Bas_tenantcreatetime_Nullable
      {
         get {
            if ( gxTv_SdtBAS_Tenant_Bas_tenantcreatetime == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtBAS_Tenant_Bas_tenantcreatetime).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtBAS_Tenant_Bas_tenantcreatetime = DateTime.MinValue;
            else
               gxTv_SdtBAS_Tenant_Bas_tenantcreatetime = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Bas_tenantcreatetime
      {
         get {
            return gxTv_SdtBAS_Tenant_Bas_tenantcreatetime ;
         }

         set {
            gxTv_SdtBAS_Tenant_Bas_tenantcreatetime = value;
            SetDirty("Bas_tenantcreatetime");
         }

      }

      [  SoapElement( ElementName = "BAS_TenantModifier" )]
      [  XmlElement( ElementName = "BAS_TenantModifier"   )]
      public String gxTpr_Bas_tenantmodifier
      {
         get {
            return gxTv_SdtBAS_Tenant_Bas_tenantmodifier ;
         }

         set {
            gxTv_SdtBAS_Tenant_Bas_tenantmodifier_N = 0;
            gxTv_SdtBAS_Tenant_Bas_tenantmodifier = value;
            SetDirty("Bas_tenantmodifier");
         }

      }

      public void gxTv_SdtBAS_Tenant_Bas_tenantmodifier_SetNull( )
      {
         gxTv_SdtBAS_Tenant_Bas_tenantmodifier_N = 1;
         gxTv_SdtBAS_Tenant_Bas_tenantmodifier = "";
         return  ;
      }

      public bool gxTv_SdtBAS_Tenant_Bas_tenantmodifier_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BAS_TenantModifyTime" )]
      [  XmlElement( ElementName = "BAS_TenantModifyTime"  , IsNullable=true )]
      public string gxTpr_Bas_tenantmodifytime_Nullable
      {
         get {
            if ( gxTv_SdtBAS_Tenant_Bas_tenantmodifytime == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtBAS_Tenant_Bas_tenantmodifytime).value ;
         }

         set {
            gxTv_SdtBAS_Tenant_Bas_tenantmodifytime_N = 0;
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtBAS_Tenant_Bas_tenantmodifytime = DateTime.MinValue;
            else
               gxTv_SdtBAS_Tenant_Bas_tenantmodifytime = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Bas_tenantmodifytime
      {
         get {
            return gxTv_SdtBAS_Tenant_Bas_tenantmodifytime ;
         }

         set {
            gxTv_SdtBAS_Tenant_Bas_tenantmodifytime_N = 0;
            gxTv_SdtBAS_Tenant_Bas_tenantmodifytime = value;
            SetDirty("Bas_tenantmodifytime");
         }

      }

      public void gxTv_SdtBAS_Tenant_Bas_tenantmodifytime_SetNull( )
      {
         gxTv_SdtBAS_Tenant_Bas_tenantmodifytime_N = 1;
         gxTv_SdtBAS_Tenant_Bas_tenantmodifytime = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBAS_Tenant_Bas_tenantmodifytime_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BAS_TenantIsDeleted" )]
      [  XmlElement( ElementName = "BAS_TenantIsDeleted"   )]
      public short gxTpr_Bas_tenantisdeleted
      {
         get {
            return gxTv_SdtBAS_Tenant_Bas_tenantisdeleted ;
         }

         set {
            gxTv_SdtBAS_Tenant_Bas_tenantisdeleted = value;
            SetDirty("Bas_tenantisdeleted");
         }

      }

      [  SoapElement( ElementName = "BAS_TenantDescription" )]
      [  XmlElement( ElementName = "BAS_TenantDescription"   )]
      public String gxTpr_Bas_tenantdescription
      {
         get {
            return gxTv_SdtBAS_Tenant_Bas_tenantdescription ;
         }

         set {
            gxTv_SdtBAS_Tenant_Bas_tenantdescription_N = 0;
            gxTv_SdtBAS_Tenant_Bas_tenantdescription = value;
            SetDirty("Bas_tenantdescription");
         }

      }

      public void gxTv_SdtBAS_Tenant_Bas_tenantdescription_SetNull( )
      {
         gxTv_SdtBAS_Tenant_Bas_tenantdescription_N = 1;
         gxTv_SdtBAS_Tenant_Bas_tenantdescription = "";
         return  ;
      }

      public bool gxTv_SdtBAS_Tenant_Bas_tenantdescription_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtBAS_Tenant_Mode ;
         }

         set {
            gxTv_SdtBAS_Tenant_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtBAS_Tenant_Mode_SetNull( )
      {
         gxTv_SdtBAS_Tenant_Mode = "";
         return  ;
      }

      public bool gxTv_SdtBAS_Tenant_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtBAS_Tenant_Initialized ;
         }

         set {
            gxTv_SdtBAS_Tenant_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtBAS_Tenant_Initialized_SetNull( )
      {
         gxTv_SdtBAS_Tenant_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtBAS_Tenant_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BAS_TenantTenantCode_Z" )]
      [  XmlElement( ElementName = "BAS_TenantTenantCode_Z"   )]
      public String gxTpr_Bas_tenanttenantcode_Z
      {
         get {
            return gxTv_SdtBAS_Tenant_Bas_tenanttenantcode_Z ;
         }

         set {
            gxTv_SdtBAS_Tenant_Bas_tenanttenantcode_Z = value;
            SetDirty("Bas_tenanttenantcode_Z");
         }

      }

      public void gxTv_SdtBAS_Tenant_Bas_tenanttenantcode_Z_SetNull( )
      {
         gxTv_SdtBAS_Tenant_Bas_tenanttenantcode_Z = "";
         return  ;
      }

      public bool gxTv_SdtBAS_Tenant_Bas_tenanttenantcode_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "TenantName_Z" )]
      [  XmlElement( ElementName = "TenantName_Z"   )]
      public String gxTpr_Tenantname_Z
      {
         get {
            return gxTv_SdtBAS_Tenant_Tenantname_Z ;
         }

         set {
            gxTv_SdtBAS_Tenant_Tenantname_Z = value;
            SetDirty("Tenantname_Z");
         }

      }

      public void gxTv_SdtBAS_Tenant_Tenantname_Z_SetNull( )
      {
         gxTv_SdtBAS_Tenant_Tenantname_Z = "";
         return  ;
      }

      public bool gxTv_SdtBAS_Tenant_Tenantname_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "InstituteCode_Z" )]
      [  XmlElement( ElementName = "InstituteCode_Z"   )]
      public String gxTpr_Institutecode_Z
      {
         get {
            return gxTv_SdtBAS_Tenant_Institutecode_Z ;
         }

         set {
            gxTv_SdtBAS_Tenant_Institutecode_Z = value;
            SetDirty("Institutecode_Z");
         }

      }

      public void gxTv_SdtBAS_Tenant_Institutecode_Z_SetNull( )
      {
         gxTv_SdtBAS_Tenant_Institutecode_Z = "";
         return  ;
      }

      public bool gxTv_SdtBAS_Tenant_Institutecode_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "HospitalName_Z" )]
      [  XmlElement( ElementName = "HospitalName_Z"   )]
      public String gxTpr_Hospitalname_Z
      {
         get {
            return gxTv_SdtBAS_Tenant_Hospitalname_Z ;
         }

         set {
            gxTv_SdtBAS_Tenant_Hospitalname_Z = value;
            SetDirty("Hospitalname_Z");
         }

      }

      public void gxTv_SdtBAS_Tenant_Hospitalname_Z_SetNull( )
      {
         gxTv_SdtBAS_Tenant_Hospitalname_Z = "";
         return  ;
      }

      public bool gxTv_SdtBAS_Tenant_Hospitalname_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "DatabaseID_Z" )]
      [  XmlElement( ElementName = "DatabaseID_Z"   )]
      public int gxTpr_Databaseid_Z
      {
         get {
            return gxTv_SdtBAS_Tenant_Databaseid_Z ;
         }

         set {
            gxTv_SdtBAS_Tenant_Databaseid_Z = value;
            SetDirty("Databaseid_Z");
         }

      }

      public void gxTv_SdtBAS_Tenant_Databaseid_Z_SetNull( )
      {
         gxTv_SdtBAS_Tenant_Databaseid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBAS_Tenant_Databaseid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BAS_TenantCreator_Z" )]
      [  XmlElement( ElementName = "BAS_TenantCreator_Z"   )]
      public String gxTpr_Bas_tenantcreator_Z
      {
         get {
            return gxTv_SdtBAS_Tenant_Bas_tenantcreator_Z ;
         }

         set {
            gxTv_SdtBAS_Tenant_Bas_tenantcreator_Z = value;
            SetDirty("Bas_tenantcreator_Z");
         }

      }

      public void gxTv_SdtBAS_Tenant_Bas_tenantcreator_Z_SetNull( )
      {
         gxTv_SdtBAS_Tenant_Bas_tenantcreator_Z = "";
         return  ;
      }

      public bool gxTv_SdtBAS_Tenant_Bas_tenantcreator_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BAS_TenantCreateTime_Z" )]
      [  XmlElement( ElementName = "BAS_TenantCreateTime_Z"  , IsNullable=true )]
      public string gxTpr_Bas_tenantcreatetime_Z_Nullable
      {
         get {
            if ( gxTv_SdtBAS_Tenant_Bas_tenantcreatetime_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtBAS_Tenant_Bas_tenantcreatetime_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtBAS_Tenant_Bas_tenantcreatetime_Z = DateTime.MinValue;
            else
               gxTv_SdtBAS_Tenant_Bas_tenantcreatetime_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Bas_tenantcreatetime_Z
      {
         get {
            return gxTv_SdtBAS_Tenant_Bas_tenantcreatetime_Z ;
         }

         set {
            gxTv_SdtBAS_Tenant_Bas_tenantcreatetime_Z = value;
            SetDirty("Bas_tenantcreatetime_Z");
         }

      }

      public void gxTv_SdtBAS_Tenant_Bas_tenantcreatetime_Z_SetNull( )
      {
         gxTv_SdtBAS_Tenant_Bas_tenantcreatetime_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBAS_Tenant_Bas_tenantcreatetime_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BAS_TenantModifier_Z" )]
      [  XmlElement( ElementName = "BAS_TenantModifier_Z"   )]
      public String gxTpr_Bas_tenantmodifier_Z
      {
         get {
            return gxTv_SdtBAS_Tenant_Bas_tenantmodifier_Z ;
         }

         set {
            gxTv_SdtBAS_Tenant_Bas_tenantmodifier_Z = value;
            SetDirty("Bas_tenantmodifier_Z");
         }

      }

      public void gxTv_SdtBAS_Tenant_Bas_tenantmodifier_Z_SetNull( )
      {
         gxTv_SdtBAS_Tenant_Bas_tenantmodifier_Z = "";
         return  ;
      }

      public bool gxTv_SdtBAS_Tenant_Bas_tenantmodifier_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BAS_TenantModifyTime_Z" )]
      [  XmlElement( ElementName = "BAS_TenantModifyTime_Z"  , IsNullable=true )]
      public string gxTpr_Bas_tenantmodifytime_Z_Nullable
      {
         get {
            if ( gxTv_SdtBAS_Tenant_Bas_tenantmodifytime_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtBAS_Tenant_Bas_tenantmodifytime_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtBAS_Tenant_Bas_tenantmodifytime_Z = DateTime.MinValue;
            else
               gxTv_SdtBAS_Tenant_Bas_tenantmodifytime_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Bas_tenantmodifytime_Z
      {
         get {
            return gxTv_SdtBAS_Tenant_Bas_tenantmodifytime_Z ;
         }

         set {
            gxTv_SdtBAS_Tenant_Bas_tenantmodifytime_Z = value;
            SetDirty("Bas_tenantmodifytime_Z");
         }

      }

      public void gxTv_SdtBAS_Tenant_Bas_tenantmodifytime_Z_SetNull( )
      {
         gxTv_SdtBAS_Tenant_Bas_tenantmodifytime_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBAS_Tenant_Bas_tenantmodifytime_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BAS_TenantIsDeleted_Z" )]
      [  XmlElement( ElementName = "BAS_TenantIsDeleted_Z"   )]
      public short gxTpr_Bas_tenantisdeleted_Z
      {
         get {
            return gxTv_SdtBAS_Tenant_Bas_tenantisdeleted_Z ;
         }

         set {
            gxTv_SdtBAS_Tenant_Bas_tenantisdeleted_Z = value;
            SetDirty("Bas_tenantisdeleted_Z");
         }

      }

      public void gxTv_SdtBAS_Tenant_Bas_tenantisdeleted_Z_SetNull( )
      {
         gxTv_SdtBAS_Tenant_Bas_tenantisdeleted_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBAS_Tenant_Bas_tenantisdeleted_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "InstituteCode_N" )]
      [  XmlElement( ElementName = "InstituteCode_N"   )]
      public short gxTpr_Institutecode_N
      {
         get {
            return gxTv_SdtBAS_Tenant_Institutecode_N ;
         }

         set {
            gxTv_SdtBAS_Tenant_Institutecode_N = value;
            SetDirty("Institutecode_N");
         }

      }

      public void gxTv_SdtBAS_Tenant_Institutecode_N_SetNull( )
      {
         gxTv_SdtBAS_Tenant_Institutecode_N = 0;
         return  ;
      }

      public bool gxTv_SdtBAS_Tenant_Institutecode_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BAS_TenantLogo_N" )]
      [  XmlElement( ElementName = "BAS_TenantLogo_N"   )]
      public short gxTpr_Bas_tenantlogo_N
      {
         get {
            return gxTv_SdtBAS_Tenant_Bas_tenantlogo_N ;
         }

         set {
            gxTv_SdtBAS_Tenant_Bas_tenantlogo_N = value;
            SetDirty("Bas_tenantlogo_N");
         }

      }

      public void gxTv_SdtBAS_Tenant_Bas_tenantlogo_N_SetNull( )
      {
         gxTv_SdtBAS_Tenant_Bas_tenantlogo_N = 0;
         return  ;
      }

      public bool gxTv_SdtBAS_Tenant_Bas_tenantlogo_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BAS_TenantModifier_N" )]
      [  XmlElement( ElementName = "BAS_TenantModifier_N"   )]
      public short gxTpr_Bas_tenantmodifier_N
      {
         get {
            return gxTv_SdtBAS_Tenant_Bas_tenantmodifier_N ;
         }

         set {
            gxTv_SdtBAS_Tenant_Bas_tenantmodifier_N = value;
            SetDirty("Bas_tenantmodifier_N");
         }

      }

      public void gxTv_SdtBAS_Tenant_Bas_tenantmodifier_N_SetNull( )
      {
         gxTv_SdtBAS_Tenant_Bas_tenantmodifier_N = 0;
         return  ;
      }

      public bool gxTv_SdtBAS_Tenant_Bas_tenantmodifier_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BAS_TenantModifyTime_N" )]
      [  XmlElement( ElementName = "BAS_TenantModifyTime_N"   )]
      public short gxTpr_Bas_tenantmodifytime_N
      {
         get {
            return gxTv_SdtBAS_Tenant_Bas_tenantmodifytime_N ;
         }

         set {
            gxTv_SdtBAS_Tenant_Bas_tenantmodifytime_N = value;
            SetDirty("Bas_tenantmodifytime_N");
         }

      }

      public void gxTv_SdtBAS_Tenant_Bas_tenantmodifytime_N_SetNull( )
      {
         gxTv_SdtBAS_Tenant_Bas_tenantmodifytime_N = 0;
         return  ;
      }

      public bool gxTv_SdtBAS_Tenant_Bas_tenantmodifytime_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BAS_TenantDescription_N" )]
      [  XmlElement( ElementName = "BAS_TenantDescription_N"   )]
      public short gxTpr_Bas_tenantdescription_N
      {
         get {
            return gxTv_SdtBAS_Tenant_Bas_tenantdescription_N ;
         }

         set {
            gxTv_SdtBAS_Tenant_Bas_tenantdescription_N = value;
            SetDirty("Bas_tenantdescription_N");
         }

      }

      public void gxTv_SdtBAS_Tenant_Bas_tenantdescription_N_SetNull( )
      {
         gxTv_SdtBAS_Tenant_Bas_tenantdescription_N = 0;
         return  ;
      }

      public bool gxTv_SdtBAS_Tenant_Bas_tenantdescription_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtBAS_Tenant_Bas_tenanttenantcode = "";
         gxTv_SdtBAS_Tenant_Tenantname = "";
         gxTv_SdtBAS_Tenant_Institutecode = "";
         gxTv_SdtBAS_Tenant_Hospitalname = "";
         gxTv_SdtBAS_Tenant_Bas_tenantlogo = "";
         gxTv_SdtBAS_Tenant_Bas_tenantcreator = "";
         gxTv_SdtBAS_Tenant_Bas_tenantcreatetime = (DateTime)(DateTime.MinValue);
         gxTv_SdtBAS_Tenant_Bas_tenantmodifier = "";
         gxTv_SdtBAS_Tenant_Bas_tenantmodifytime = (DateTime)(DateTime.MinValue);
         gxTv_SdtBAS_Tenant_Bas_tenantdescription = "";
         gxTv_SdtBAS_Tenant_Mode = "";
         gxTv_SdtBAS_Tenant_Bas_tenanttenantcode_Z = "";
         gxTv_SdtBAS_Tenant_Tenantname_Z = "";
         gxTv_SdtBAS_Tenant_Institutecode_Z = "";
         gxTv_SdtBAS_Tenant_Hospitalname_Z = "";
         gxTv_SdtBAS_Tenant_Bas_tenantcreator_Z = "";
         gxTv_SdtBAS_Tenant_Bas_tenantcreatetime_Z = (DateTime)(DateTime.MinValue);
         gxTv_SdtBAS_Tenant_Bas_tenantmodifier_Z = "";
         gxTv_SdtBAS_Tenant_Bas_tenantmodifytime_Z = (DateTime)(DateTime.MinValue);
         datetime_STZ = (DateTime)(DateTime.MinValue);
         sDateCnv = "";
         sNumToPad = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "bas_tenant", "GeneXus.Programs.bas_tenant_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtBAS_Tenant_Bas_tenantisdeleted ;
      private short gxTv_SdtBAS_Tenant_Initialized ;
      private short gxTv_SdtBAS_Tenant_Bas_tenantisdeleted_Z ;
      private short gxTv_SdtBAS_Tenant_Institutecode_N ;
      private short gxTv_SdtBAS_Tenant_Bas_tenantlogo_N ;
      private short gxTv_SdtBAS_Tenant_Bas_tenantmodifier_N ;
      private short gxTv_SdtBAS_Tenant_Bas_tenantmodifytime_N ;
      private short gxTv_SdtBAS_Tenant_Bas_tenantdescription_N ;
      private int gxTv_SdtBAS_Tenant_Databaseid ;
      private int gxTv_SdtBAS_Tenant_Databaseid_Z ;
      private String gxTv_SdtBAS_Tenant_Mode ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_SdtBAS_Tenant_Bas_tenantcreatetime ;
      private DateTime gxTv_SdtBAS_Tenant_Bas_tenantmodifytime ;
      private DateTime gxTv_SdtBAS_Tenant_Bas_tenantcreatetime_Z ;
      private DateTime gxTv_SdtBAS_Tenant_Bas_tenantmodifytime_Z ;
      private DateTime datetime_STZ ;
      private String gxTv_SdtBAS_Tenant_Bas_tenantdescription ;
      private String gxTv_SdtBAS_Tenant_Bas_tenanttenantcode ;
      private String gxTv_SdtBAS_Tenant_Tenantname ;
      private String gxTv_SdtBAS_Tenant_Institutecode ;
      private String gxTv_SdtBAS_Tenant_Hospitalname ;
      private String gxTv_SdtBAS_Tenant_Bas_tenantcreator ;
      private String gxTv_SdtBAS_Tenant_Bas_tenantmodifier ;
      private String gxTv_SdtBAS_Tenant_Bas_tenanttenantcode_Z ;
      private String gxTv_SdtBAS_Tenant_Tenantname_Z ;
      private String gxTv_SdtBAS_Tenant_Institutecode_Z ;
      private String gxTv_SdtBAS_Tenant_Hospitalname_Z ;
      private String gxTv_SdtBAS_Tenant_Bas_tenantcreator_Z ;
      private String gxTv_SdtBAS_Tenant_Bas_tenantmodifier_Z ;
      private String gxTv_SdtBAS_Tenant_Bas_tenantlogo ;
   }

   [DataContract(Name = @"BAS_Tenant", Namespace = "DataAnalysisPlatform")]
   public class SdtBAS_Tenant_RESTInterface : GxGenericCollectionItem<SdtBAS_Tenant>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBAS_Tenant_RESTInterface( ) : base()
      {
      }

      public SdtBAS_Tenant_RESTInterface( SdtBAS_Tenant psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "BAS_TenantTenantCode" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Bas_tenanttenantcode
      {
         get {
            return sdt.gxTpr_Bas_tenanttenantcode ;
         }

         set {
            sdt.gxTpr_Bas_tenanttenantcode = value;
         }

      }

      [DataMember( Name = "TenantName" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Tenantname
      {
         get {
            return sdt.gxTpr_Tenantname ;
         }

         set {
            sdt.gxTpr_Tenantname = value;
         }

      }

      [DataMember( Name = "InstituteCode" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Institutecode
      {
         get {
            return sdt.gxTpr_Institutecode ;
         }

         set {
            sdt.gxTpr_Institutecode = value;
         }

      }

      [DataMember( Name = "HospitalName" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Hospitalname
      {
         get {
            return sdt.gxTpr_Hospitalname ;
         }

         set {
            sdt.gxTpr_Hospitalname = value;
         }

      }

      [DataMember( Name = "DatabaseID" , Order = 4 )]
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

      [DataMember( Name = "BAS_TenantLogo" , Order = 5 )]
      [GxUpload()]
      public String gxTpr_Bas_tenantlogo
      {
         get {
            return PathUtil.RelativeURL( sdt.gxTpr_Bas_tenantlogo) ;
         }

         set {
            sdt.gxTpr_Bas_tenantlogo = value;
         }

      }

      [DataMember( Name = "BAS_TenantCreator" , Order = 6 )]
      [GxSeudo()]
      public String gxTpr_Bas_tenantcreator
      {
         get {
            return sdt.gxTpr_Bas_tenantcreator ;
         }

         set {
            sdt.gxTpr_Bas_tenantcreator = value;
         }

      }

      [DataMember( Name = "BAS_TenantCreateTime" , Order = 7 )]
      [GxSeudo()]
      public String gxTpr_Bas_tenantcreatetime
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Bas_tenantcreatetime) ;
         }

         set {
            sdt.gxTpr_Bas_tenantcreatetime = DateTimeUtil.CToT2( value);
         }

      }

      [DataMember( Name = "BAS_TenantModifier" , Order = 8 )]
      [GxSeudo()]
      public String gxTpr_Bas_tenantmodifier
      {
         get {
            return sdt.gxTpr_Bas_tenantmodifier ;
         }

         set {
            sdt.gxTpr_Bas_tenantmodifier = value;
         }

      }

      [DataMember( Name = "BAS_TenantModifyTime" , Order = 9 )]
      [GxSeudo()]
      public String gxTpr_Bas_tenantmodifytime
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Bas_tenantmodifytime) ;
         }

         set {
            sdt.gxTpr_Bas_tenantmodifytime = DateTimeUtil.CToT2( value);
         }

      }

      [DataMember( Name = "BAS_TenantIsDeleted" , Order = 10 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Bas_tenantisdeleted
      {
         get {
            return sdt.gxTpr_Bas_tenantisdeleted ;
         }

         set {
            sdt.gxTpr_Bas_tenantisdeleted = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "BAS_TenantDescription" , Order = 11 )]
      public String gxTpr_Bas_tenantdescription
      {
         get {
            return sdt.gxTpr_Bas_tenantdescription ;
         }

         set {
            sdt.gxTpr_Bas_tenantdescription = value;
         }

      }

      public SdtBAS_Tenant sdt
      {
         get {
            return (SdtBAS_Tenant)Sdt ;
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
            sdt = new SdtBAS_Tenant() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 12 )]
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

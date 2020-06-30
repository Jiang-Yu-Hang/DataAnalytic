/*
               File: type_SdtBAS_Institute
        Description: BAS_Institute
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:9:2.5
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
   [XmlRoot(ElementName = "BAS_Institute" )]
   [XmlType(TypeName =  "BAS_Institute" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtBAS_Institute : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBAS_Institute( )
      {
      }

      public SdtBAS_Institute( IGxContext context )
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

      public void Load( String AV358InstituteCode )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(String)AV358InstituteCode});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"InstituteCode", typeof(String)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "BAS_Institute");
         metadata.Set("BT", "BAS_INSTITUTE");
         metadata.Set("PK", "[ \"InstituteCode\" ]");
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
         state.Add("gxTpr_Institutecode_Z");
         state.Add("gxTpr_Institutename_Z");
         state.Add("gxTpr_Bas_institutecreator_Z");
         state.Add("gxTpr_Bas_institutecreatetime_Z_Nullable");
         state.Add("gxTpr_Bas_institutemodifier_Z");
         state.Add("gxTpr_Bas_institutemodifytime_Z_Nullable");
         state.Add("gxTpr_Bas_instituteisdeleted_Z");
         state.Add("gxTpr_Institutecode_N");
         state.Add("gxTpr_Bas_institutelogo_N");
         state.Add("gxTpr_Bas_institutemodifier_N");
         state.Add("gxTpr_Bas_institutemodifytime_N");
         state.Add("gxTpr_Bas_institutedescription_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtBAS_Institute sdt ;
         sdt = (SdtBAS_Institute)(source);
         gxTv_SdtBAS_Institute_Institutecode = sdt.gxTv_SdtBAS_Institute_Institutecode ;
         gxTv_SdtBAS_Institute_Institutename = sdt.gxTv_SdtBAS_Institute_Institutename ;
         gxTv_SdtBAS_Institute_Bas_institutelogo = sdt.gxTv_SdtBAS_Institute_Bas_institutelogo ;
         gxTv_SdtBAS_Institute_Bas_institutecreator = sdt.gxTv_SdtBAS_Institute_Bas_institutecreator ;
         gxTv_SdtBAS_Institute_Bas_institutecreatetime = sdt.gxTv_SdtBAS_Institute_Bas_institutecreatetime ;
         gxTv_SdtBAS_Institute_Bas_institutemodifier = sdt.gxTv_SdtBAS_Institute_Bas_institutemodifier ;
         gxTv_SdtBAS_Institute_Bas_institutemodifytime = sdt.gxTv_SdtBAS_Institute_Bas_institutemodifytime ;
         gxTv_SdtBAS_Institute_Bas_instituteisdeleted = sdt.gxTv_SdtBAS_Institute_Bas_instituteisdeleted ;
         gxTv_SdtBAS_Institute_Bas_institutedescription = sdt.gxTv_SdtBAS_Institute_Bas_institutedescription ;
         gxTv_SdtBAS_Institute_Mode = sdt.gxTv_SdtBAS_Institute_Mode ;
         gxTv_SdtBAS_Institute_Initialized = sdt.gxTv_SdtBAS_Institute_Initialized ;
         gxTv_SdtBAS_Institute_Institutecode_Z = sdt.gxTv_SdtBAS_Institute_Institutecode_Z ;
         gxTv_SdtBAS_Institute_Institutename_Z = sdt.gxTv_SdtBAS_Institute_Institutename_Z ;
         gxTv_SdtBAS_Institute_Bas_institutecreator_Z = sdt.gxTv_SdtBAS_Institute_Bas_institutecreator_Z ;
         gxTv_SdtBAS_Institute_Bas_institutecreatetime_Z = sdt.gxTv_SdtBAS_Institute_Bas_institutecreatetime_Z ;
         gxTv_SdtBAS_Institute_Bas_institutemodifier_Z = sdt.gxTv_SdtBAS_Institute_Bas_institutemodifier_Z ;
         gxTv_SdtBAS_Institute_Bas_institutemodifytime_Z = sdt.gxTv_SdtBAS_Institute_Bas_institutemodifytime_Z ;
         gxTv_SdtBAS_Institute_Bas_instituteisdeleted_Z = sdt.gxTv_SdtBAS_Institute_Bas_instituteisdeleted_Z ;
         gxTv_SdtBAS_Institute_Institutecode_N = sdt.gxTv_SdtBAS_Institute_Institutecode_N ;
         gxTv_SdtBAS_Institute_Bas_institutelogo_N = sdt.gxTv_SdtBAS_Institute_Bas_institutelogo_N ;
         gxTv_SdtBAS_Institute_Bas_institutemodifier_N = sdt.gxTv_SdtBAS_Institute_Bas_institutemodifier_N ;
         gxTv_SdtBAS_Institute_Bas_institutemodifytime_N = sdt.gxTv_SdtBAS_Institute_Bas_institutemodifytime_N ;
         gxTv_SdtBAS_Institute_Bas_institutedescription_N = sdt.gxTv_SdtBAS_Institute_Bas_institutedescription_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("InstituteCode", gxTv_SdtBAS_Institute_Institutecode, false);
         AddObjectProperty("InstituteCode_N", gxTv_SdtBAS_Institute_Institutecode_N, false);
         AddObjectProperty("InstituteName", gxTv_SdtBAS_Institute_Institutename, false);
         AddObjectProperty("BAS_InstituteLogo", gxTv_SdtBAS_Institute_Bas_institutelogo, false);
         AddObjectProperty("BAS_InstituteLogo_N", gxTv_SdtBAS_Institute_Bas_institutelogo_N, false);
         AddObjectProperty("BAS_InstituteCreator", gxTv_SdtBAS_Institute_Bas_institutecreator, false);
         datetime_STZ = gxTv_SdtBAS_Institute_Bas_institutecreatetime;
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
         AddObjectProperty("BAS_InstituteCreateTime", sDateCnv, false);
         AddObjectProperty("BAS_InstituteModifier", gxTv_SdtBAS_Institute_Bas_institutemodifier, false);
         AddObjectProperty("BAS_InstituteModifier_N", gxTv_SdtBAS_Institute_Bas_institutemodifier_N, false);
         datetime_STZ = gxTv_SdtBAS_Institute_Bas_institutemodifytime;
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
         AddObjectProperty("BAS_InstituteModifyTime", sDateCnv, false);
         AddObjectProperty("BAS_InstituteModifyTime_N", gxTv_SdtBAS_Institute_Bas_institutemodifytime_N, false);
         AddObjectProperty("BAS_InstituteIsDeleted", gxTv_SdtBAS_Institute_Bas_instituteisdeleted, false);
         AddObjectProperty("BAS_InstituteDescription", gxTv_SdtBAS_Institute_Bas_institutedescription, false);
         AddObjectProperty("BAS_InstituteDescription_N", gxTv_SdtBAS_Institute_Bas_institutedescription_N, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtBAS_Institute_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtBAS_Institute_Initialized, false);
            AddObjectProperty("InstituteCode_Z", gxTv_SdtBAS_Institute_Institutecode_Z, false);
            AddObjectProperty("InstituteName_Z", gxTv_SdtBAS_Institute_Institutename_Z, false);
            AddObjectProperty("BAS_InstituteCreator_Z", gxTv_SdtBAS_Institute_Bas_institutecreator_Z, false);
            datetime_STZ = gxTv_SdtBAS_Institute_Bas_institutecreatetime_Z;
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
            AddObjectProperty("BAS_InstituteCreateTime_Z", sDateCnv, false);
            AddObjectProperty("BAS_InstituteModifier_Z", gxTv_SdtBAS_Institute_Bas_institutemodifier_Z, false);
            datetime_STZ = gxTv_SdtBAS_Institute_Bas_institutemodifytime_Z;
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
            AddObjectProperty("BAS_InstituteModifyTime_Z", sDateCnv, false);
            AddObjectProperty("BAS_InstituteIsDeleted_Z", gxTv_SdtBAS_Institute_Bas_instituteisdeleted_Z, false);
            AddObjectProperty("InstituteCode_N", gxTv_SdtBAS_Institute_Institutecode_N, false);
            AddObjectProperty("BAS_InstituteLogo_N", gxTv_SdtBAS_Institute_Bas_institutelogo_N, false);
            AddObjectProperty("BAS_InstituteModifier_N", gxTv_SdtBAS_Institute_Bas_institutemodifier_N, false);
            AddObjectProperty("BAS_InstituteModifyTime_N", gxTv_SdtBAS_Institute_Bas_institutemodifytime_N, false);
            AddObjectProperty("BAS_InstituteDescription_N", gxTv_SdtBAS_Institute_Bas_institutedescription_N, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtBAS_Institute sdt )
      {
         if ( sdt.IsDirty("InstituteCode") )
         {
            gxTv_SdtBAS_Institute_Institutecode = sdt.gxTv_SdtBAS_Institute_Institutecode ;
         }
         if ( sdt.IsDirty("InstituteName") )
         {
            gxTv_SdtBAS_Institute_Institutename = sdt.gxTv_SdtBAS_Institute_Institutename ;
         }
         if ( sdt.IsDirty("BAS_InstituteLogo") )
         {
            gxTv_SdtBAS_Institute_Bas_institutelogo = sdt.gxTv_SdtBAS_Institute_Bas_institutelogo ;
         }
         if ( sdt.IsDirty("BAS_InstituteCreator") )
         {
            gxTv_SdtBAS_Institute_Bas_institutecreator = sdt.gxTv_SdtBAS_Institute_Bas_institutecreator ;
         }
         if ( sdt.IsDirty("BAS_InstituteCreateTime") )
         {
            gxTv_SdtBAS_Institute_Bas_institutecreatetime = sdt.gxTv_SdtBAS_Institute_Bas_institutecreatetime ;
         }
         if ( sdt.IsDirty("BAS_InstituteModifier") )
         {
            gxTv_SdtBAS_Institute_Bas_institutemodifier = sdt.gxTv_SdtBAS_Institute_Bas_institutemodifier ;
         }
         if ( sdt.IsDirty("BAS_InstituteModifyTime") )
         {
            gxTv_SdtBAS_Institute_Bas_institutemodifytime = sdt.gxTv_SdtBAS_Institute_Bas_institutemodifytime ;
         }
         if ( sdt.IsDirty("BAS_InstituteIsDeleted") )
         {
            gxTv_SdtBAS_Institute_Bas_instituteisdeleted = sdt.gxTv_SdtBAS_Institute_Bas_instituteisdeleted ;
         }
         if ( sdt.IsDirty("BAS_InstituteDescription") )
         {
            gxTv_SdtBAS_Institute_Bas_institutedescription = sdt.gxTv_SdtBAS_Institute_Bas_institutedescription ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "InstituteCode" )]
      [  XmlElement( ElementName = "InstituteCode"   )]
      public String gxTpr_Institutecode
      {
         get {
            return gxTv_SdtBAS_Institute_Institutecode ;
         }

         set {
            if ( StringUtil.StrCmp(gxTv_SdtBAS_Institute_Institutecode, value) != 0 )
            {
               gxTv_SdtBAS_Institute_Mode = "INS";
               this.gxTv_SdtBAS_Institute_Institutecode_Z_SetNull( );
               this.gxTv_SdtBAS_Institute_Institutename_Z_SetNull( );
               this.gxTv_SdtBAS_Institute_Bas_institutecreator_Z_SetNull( );
               this.gxTv_SdtBAS_Institute_Bas_institutecreatetime_Z_SetNull( );
               this.gxTv_SdtBAS_Institute_Bas_institutemodifier_Z_SetNull( );
               this.gxTv_SdtBAS_Institute_Bas_institutemodifytime_Z_SetNull( );
               this.gxTv_SdtBAS_Institute_Bas_instituteisdeleted_Z_SetNull( );
            }
            gxTv_SdtBAS_Institute_Institutecode = value;
            SetDirty("Institutecode");
         }

      }

      [  SoapElement( ElementName = "InstituteName" )]
      [  XmlElement( ElementName = "InstituteName"   )]
      public String gxTpr_Institutename
      {
         get {
            return gxTv_SdtBAS_Institute_Institutename ;
         }

         set {
            gxTv_SdtBAS_Institute_Institutename = value;
            SetDirty("Institutename");
         }

      }

      [  SoapElement( ElementName = "BAS_InstituteLogo" )]
      [  XmlElement( ElementName = "BAS_InstituteLogo"   )]
      [GxUpload()]
      public byte[] gxTpr_Bas_institutelogo_Blob
      {
         get {
            IGxContext context = this.context == null ? new GxContext() : this.context;
            return context.FileToByteArray( gxTv_SdtBAS_Institute_Bas_institutelogo) ;
         }

         set {
            gxTv_SdtBAS_Institute_Bas_institutelogo_N = 0;
            IGxContext context = this.context == null ? new GxContext() : this.context;
            gxTv_SdtBAS_Institute_Bas_institutelogo=context.FileFromByteArray( value) ;
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      [GxUpload()]
      public String gxTpr_Bas_institutelogo
      {
         get {
            return gxTv_SdtBAS_Institute_Bas_institutelogo ;
         }

         set {
            gxTv_SdtBAS_Institute_Bas_institutelogo_N = 0;
            gxTv_SdtBAS_Institute_Bas_institutelogo = value;
            SetDirty("Bas_institutelogo");
         }

      }

      public void gxTv_SdtBAS_Institute_Bas_institutelogo_SetBlob( String blob ,
                                                                   String fileName ,
                                                                   String fileType )
      {
         gxTv_SdtBAS_Institute_Bas_institutelogo = blob;
         return  ;
      }

      public void gxTv_SdtBAS_Institute_Bas_institutelogo_SetNull( )
      {
         gxTv_SdtBAS_Institute_Bas_institutelogo_N = 1;
         gxTv_SdtBAS_Institute_Bas_institutelogo = "";
         return  ;
      }

      public bool gxTv_SdtBAS_Institute_Bas_institutelogo_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BAS_InstituteCreator" )]
      [  XmlElement( ElementName = "BAS_InstituteCreator"   )]
      public String gxTpr_Bas_institutecreator
      {
         get {
            return gxTv_SdtBAS_Institute_Bas_institutecreator ;
         }

         set {
            gxTv_SdtBAS_Institute_Bas_institutecreator = value;
            SetDirty("Bas_institutecreator");
         }

      }

      [  SoapElement( ElementName = "BAS_InstituteCreateTime" )]
      [  XmlElement( ElementName = "BAS_InstituteCreateTime"  , IsNullable=true )]
      public string gxTpr_Bas_institutecreatetime_Nullable
      {
         get {
            if ( gxTv_SdtBAS_Institute_Bas_institutecreatetime == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtBAS_Institute_Bas_institutecreatetime).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtBAS_Institute_Bas_institutecreatetime = DateTime.MinValue;
            else
               gxTv_SdtBAS_Institute_Bas_institutecreatetime = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Bas_institutecreatetime
      {
         get {
            return gxTv_SdtBAS_Institute_Bas_institutecreatetime ;
         }

         set {
            gxTv_SdtBAS_Institute_Bas_institutecreatetime = value;
            SetDirty("Bas_institutecreatetime");
         }

      }

      [  SoapElement( ElementName = "BAS_InstituteModifier" )]
      [  XmlElement( ElementName = "BAS_InstituteModifier"   )]
      public String gxTpr_Bas_institutemodifier
      {
         get {
            return gxTv_SdtBAS_Institute_Bas_institutemodifier ;
         }

         set {
            gxTv_SdtBAS_Institute_Bas_institutemodifier_N = 0;
            gxTv_SdtBAS_Institute_Bas_institutemodifier = value;
            SetDirty("Bas_institutemodifier");
         }

      }

      public void gxTv_SdtBAS_Institute_Bas_institutemodifier_SetNull( )
      {
         gxTv_SdtBAS_Institute_Bas_institutemodifier_N = 1;
         gxTv_SdtBAS_Institute_Bas_institutemodifier = "";
         return  ;
      }

      public bool gxTv_SdtBAS_Institute_Bas_institutemodifier_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BAS_InstituteModifyTime" )]
      [  XmlElement( ElementName = "BAS_InstituteModifyTime"  , IsNullable=true )]
      public string gxTpr_Bas_institutemodifytime_Nullable
      {
         get {
            if ( gxTv_SdtBAS_Institute_Bas_institutemodifytime == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtBAS_Institute_Bas_institutemodifytime).value ;
         }

         set {
            gxTv_SdtBAS_Institute_Bas_institutemodifytime_N = 0;
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtBAS_Institute_Bas_institutemodifytime = DateTime.MinValue;
            else
               gxTv_SdtBAS_Institute_Bas_institutemodifytime = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Bas_institutemodifytime
      {
         get {
            return gxTv_SdtBAS_Institute_Bas_institutemodifytime ;
         }

         set {
            gxTv_SdtBAS_Institute_Bas_institutemodifytime_N = 0;
            gxTv_SdtBAS_Institute_Bas_institutemodifytime = value;
            SetDirty("Bas_institutemodifytime");
         }

      }

      public void gxTv_SdtBAS_Institute_Bas_institutemodifytime_SetNull( )
      {
         gxTv_SdtBAS_Institute_Bas_institutemodifytime_N = 1;
         gxTv_SdtBAS_Institute_Bas_institutemodifytime = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBAS_Institute_Bas_institutemodifytime_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BAS_InstituteIsDeleted" )]
      [  XmlElement( ElementName = "BAS_InstituteIsDeleted"   )]
      public short gxTpr_Bas_instituteisdeleted
      {
         get {
            return gxTv_SdtBAS_Institute_Bas_instituteisdeleted ;
         }

         set {
            gxTv_SdtBAS_Institute_Bas_instituteisdeleted = value;
            SetDirty("Bas_instituteisdeleted");
         }

      }

      [  SoapElement( ElementName = "BAS_InstituteDescription" )]
      [  XmlElement( ElementName = "BAS_InstituteDescription"   )]
      public String gxTpr_Bas_institutedescription
      {
         get {
            return gxTv_SdtBAS_Institute_Bas_institutedescription ;
         }

         set {
            gxTv_SdtBAS_Institute_Bas_institutedescription_N = 0;
            gxTv_SdtBAS_Institute_Bas_institutedescription = value;
            SetDirty("Bas_institutedescription");
         }

      }

      public void gxTv_SdtBAS_Institute_Bas_institutedescription_SetNull( )
      {
         gxTv_SdtBAS_Institute_Bas_institutedescription_N = 1;
         gxTv_SdtBAS_Institute_Bas_institutedescription = "";
         return  ;
      }

      public bool gxTv_SdtBAS_Institute_Bas_institutedescription_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtBAS_Institute_Mode ;
         }

         set {
            gxTv_SdtBAS_Institute_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtBAS_Institute_Mode_SetNull( )
      {
         gxTv_SdtBAS_Institute_Mode = "";
         return  ;
      }

      public bool gxTv_SdtBAS_Institute_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtBAS_Institute_Initialized ;
         }

         set {
            gxTv_SdtBAS_Institute_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtBAS_Institute_Initialized_SetNull( )
      {
         gxTv_SdtBAS_Institute_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtBAS_Institute_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "InstituteCode_Z" )]
      [  XmlElement( ElementName = "InstituteCode_Z"   )]
      public String gxTpr_Institutecode_Z
      {
         get {
            return gxTv_SdtBAS_Institute_Institutecode_Z ;
         }

         set {
            gxTv_SdtBAS_Institute_Institutecode_Z = value;
            SetDirty("Institutecode_Z");
         }

      }

      public void gxTv_SdtBAS_Institute_Institutecode_Z_SetNull( )
      {
         gxTv_SdtBAS_Institute_Institutecode_Z = "";
         return  ;
      }

      public bool gxTv_SdtBAS_Institute_Institutecode_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "InstituteName_Z" )]
      [  XmlElement( ElementName = "InstituteName_Z"   )]
      public String gxTpr_Institutename_Z
      {
         get {
            return gxTv_SdtBAS_Institute_Institutename_Z ;
         }

         set {
            gxTv_SdtBAS_Institute_Institutename_Z = value;
            SetDirty("Institutename_Z");
         }

      }

      public void gxTv_SdtBAS_Institute_Institutename_Z_SetNull( )
      {
         gxTv_SdtBAS_Institute_Institutename_Z = "";
         return  ;
      }

      public bool gxTv_SdtBAS_Institute_Institutename_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BAS_InstituteCreator_Z" )]
      [  XmlElement( ElementName = "BAS_InstituteCreator_Z"   )]
      public String gxTpr_Bas_institutecreator_Z
      {
         get {
            return gxTv_SdtBAS_Institute_Bas_institutecreator_Z ;
         }

         set {
            gxTv_SdtBAS_Institute_Bas_institutecreator_Z = value;
            SetDirty("Bas_institutecreator_Z");
         }

      }

      public void gxTv_SdtBAS_Institute_Bas_institutecreator_Z_SetNull( )
      {
         gxTv_SdtBAS_Institute_Bas_institutecreator_Z = "";
         return  ;
      }

      public bool gxTv_SdtBAS_Institute_Bas_institutecreator_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BAS_InstituteCreateTime_Z" )]
      [  XmlElement( ElementName = "BAS_InstituteCreateTime_Z"  , IsNullable=true )]
      public string gxTpr_Bas_institutecreatetime_Z_Nullable
      {
         get {
            if ( gxTv_SdtBAS_Institute_Bas_institutecreatetime_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtBAS_Institute_Bas_institutecreatetime_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtBAS_Institute_Bas_institutecreatetime_Z = DateTime.MinValue;
            else
               gxTv_SdtBAS_Institute_Bas_institutecreatetime_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Bas_institutecreatetime_Z
      {
         get {
            return gxTv_SdtBAS_Institute_Bas_institutecreatetime_Z ;
         }

         set {
            gxTv_SdtBAS_Institute_Bas_institutecreatetime_Z = value;
            SetDirty("Bas_institutecreatetime_Z");
         }

      }

      public void gxTv_SdtBAS_Institute_Bas_institutecreatetime_Z_SetNull( )
      {
         gxTv_SdtBAS_Institute_Bas_institutecreatetime_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBAS_Institute_Bas_institutecreatetime_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BAS_InstituteModifier_Z" )]
      [  XmlElement( ElementName = "BAS_InstituteModifier_Z"   )]
      public String gxTpr_Bas_institutemodifier_Z
      {
         get {
            return gxTv_SdtBAS_Institute_Bas_institutemodifier_Z ;
         }

         set {
            gxTv_SdtBAS_Institute_Bas_institutemodifier_Z = value;
            SetDirty("Bas_institutemodifier_Z");
         }

      }

      public void gxTv_SdtBAS_Institute_Bas_institutemodifier_Z_SetNull( )
      {
         gxTv_SdtBAS_Institute_Bas_institutemodifier_Z = "";
         return  ;
      }

      public bool gxTv_SdtBAS_Institute_Bas_institutemodifier_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BAS_InstituteModifyTime_Z" )]
      [  XmlElement( ElementName = "BAS_InstituteModifyTime_Z"  , IsNullable=true )]
      public string gxTpr_Bas_institutemodifytime_Z_Nullable
      {
         get {
            if ( gxTv_SdtBAS_Institute_Bas_institutemodifytime_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtBAS_Institute_Bas_institutemodifytime_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtBAS_Institute_Bas_institutemodifytime_Z = DateTime.MinValue;
            else
               gxTv_SdtBAS_Institute_Bas_institutemodifytime_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Bas_institutemodifytime_Z
      {
         get {
            return gxTv_SdtBAS_Institute_Bas_institutemodifytime_Z ;
         }

         set {
            gxTv_SdtBAS_Institute_Bas_institutemodifytime_Z = value;
            SetDirty("Bas_institutemodifytime_Z");
         }

      }

      public void gxTv_SdtBAS_Institute_Bas_institutemodifytime_Z_SetNull( )
      {
         gxTv_SdtBAS_Institute_Bas_institutemodifytime_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBAS_Institute_Bas_institutemodifytime_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BAS_InstituteIsDeleted_Z" )]
      [  XmlElement( ElementName = "BAS_InstituteIsDeleted_Z"   )]
      public short gxTpr_Bas_instituteisdeleted_Z
      {
         get {
            return gxTv_SdtBAS_Institute_Bas_instituteisdeleted_Z ;
         }

         set {
            gxTv_SdtBAS_Institute_Bas_instituteisdeleted_Z = value;
            SetDirty("Bas_instituteisdeleted_Z");
         }

      }

      public void gxTv_SdtBAS_Institute_Bas_instituteisdeleted_Z_SetNull( )
      {
         gxTv_SdtBAS_Institute_Bas_instituteisdeleted_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBAS_Institute_Bas_instituteisdeleted_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "InstituteCode_N" )]
      [  XmlElement( ElementName = "InstituteCode_N"   )]
      public short gxTpr_Institutecode_N
      {
         get {
            return gxTv_SdtBAS_Institute_Institutecode_N ;
         }

         set {
            gxTv_SdtBAS_Institute_Institutecode_N = value;
            SetDirty("Institutecode_N");
         }

      }

      public void gxTv_SdtBAS_Institute_Institutecode_N_SetNull( )
      {
         gxTv_SdtBAS_Institute_Institutecode_N = 0;
         return  ;
      }

      public bool gxTv_SdtBAS_Institute_Institutecode_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BAS_InstituteLogo_N" )]
      [  XmlElement( ElementName = "BAS_InstituteLogo_N"   )]
      public short gxTpr_Bas_institutelogo_N
      {
         get {
            return gxTv_SdtBAS_Institute_Bas_institutelogo_N ;
         }

         set {
            gxTv_SdtBAS_Institute_Bas_institutelogo_N = value;
            SetDirty("Bas_institutelogo_N");
         }

      }

      public void gxTv_SdtBAS_Institute_Bas_institutelogo_N_SetNull( )
      {
         gxTv_SdtBAS_Institute_Bas_institutelogo_N = 0;
         return  ;
      }

      public bool gxTv_SdtBAS_Institute_Bas_institutelogo_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BAS_InstituteModifier_N" )]
      [  XmlElement( ElementName = "BAS_InstituteModifier_N"   )]
      public short gxTpr_Bas_institutemodifier_N
      {
         get {
            return gxTv_SdtBAS_Institute_Bas_institutemodifier_N ;
         }

         set {
            gxTv_SdtBAS_Institute_Bas_institutemodifier_N = value;
            SetDirty("Bas_institutemodifier_N");
         }

      }

      public void gxTv_SdtBAS_Institute_Bas_institutemodifier_N_SetNull( )
      {
         gxTv_SdtBAS_Institute_Bas_institutemodifier_N = 0;
         return  ;
      }

      public bool gxTv_SdtBAS_Institute_Bas_institutemodifier_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BAS_InstituteModifyTime_N" )]
      [  XmlElement( ElementName = "BAS_InstituteModifyTime_N"   )]
      public short gxTpr_Bas_institutemodifytime_N
      {
         get {
            return gxTv_SdtBAS_Institute_Bas_institutemodifytime_N ;
         }

         set {
            gxTv_SdtBAS_Institute_Bas_institutemodifytime_N = value;
            SetDirty("Bas_institutemodifytime_N");
         }

      }

      public void gxTv_SdtBAS_Institute_Bas_institutemodifytime_N_SetNull( )
      {
         gxTv_SdtBAS_Institute_Bas_institutemodifytime_N = 0;
         return  ;
      }

      public bool gxTv_SdtBAS_Institute_Bas_institutemodifytime_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BAS_InstituteDescription_N" )]
      [  XmlElement( ElementName = "BAS_InstituteDescription_N"   )]
      public short gxTpr_Bas_institutedescription_N
      {
         get {
            return gxTv_SdtBAS_Institute_Bas_institutedescription_N ;
         }

         set {
            gxTv_SdtBAS_Institute_Bas_institutedescription_N = value;
            SetDirty("Bas_institutedescription_N");
         }

      }

      public void gxTv_SdtBAS_Institute_Bas_institutedescription_N_SetNull( )
      {
         gxTv_SdtBAS_Institute_Bas_institutedescription_N = 0;
         return  ;
      }

      public bool gxTv_SdtBAS_Institute_Bas_institutedescription_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtBAS_Institute_Institutecode = "";
         gxTv_SdtBAS_Institute_Institutename = "";
         gxTv_SdtBAS_Institute_Bas_institutelogo = "";
         gxTv_SdtBAS_Institute_Bas_institutecreator = "";
         gxTv_SdtBAS_Institute_Bas_institutecreatetime = (DateTime)(DateTime.MinValue);
         gxTv_SdtBAS_Institute_Bas_institutemodifier = "";
         gxTv_SdtBAS_Institute_Bas_institutemodifytime = (DateTime)(DateTime.MinValue);
         gxTv_SdtBAS_Institute_Bas_institutedescription = "";
         gxTv_SdtBAS_Institute_Mode = "";
         gxTv_SdtBAS_Institute_Institutecode_Z = "";
         gxTv_SdtBAS_Institute_Institutename_Z = "";
         gxTv_SdtBAS_Institute_Bas_institutecreator_Z = "";
         gxTv_SdtBAS_Institute_Bas_institutecreatetime_Z = (DateTime)(DateTime.MinValue);
         gxTv_SdtBAS_Institute_Bas_institutemodifier_Z = "";
         gxTv_SdtBAS_Institute_Bas_institutemodifytime_Z = (DateTime)(DateTime.MinValue);
         datetime_STZ = (DateTime)(DateTime.MinValue);
         sDateCnv = "";
         sNumToPad = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "bas_institute", "GeneXus.Programs.bas_institute_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtBAS_Institute_Bas_instituteisdeleted ;
      private short gxTv_SdtBAS_Institute_Initialized ;
      private short gxTv_SdtBAS_Institute_Bas_instituteisdeleted_Z ;
      private short gxTv_SdtBAS_Institute_Institutecode_N ;
      private short gxTv_SdtBAS_Institute_Bas_institutelogo_N ;
      private short gxTv_SdtBAS_Institute_Bas_institutemodifier_N ;
      private short gxTv_SdtBAS_Institute_Bas_institutemodifytime_N ;
      private short gxTv_SdtBAS_Institute_Bas_institutedescription_N ;
      private String gxTv_SdtBAS_Institute_Mode ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_SdtBAS_Institute_Bas_institutecreatetime ;
      private DateTime gxTv_SdtBAS_Institute_Bas_institutemodifytime ;
      private DateTime gxTv_SdtBAS_Institute_Bas_institutecreatetime_Z ;
      private DateTime gxTv_SdtBAS_Institute_Bas_institutemodifytime_Z ;
      private DateTime datetime_STZ ;
      private String gxTv_SdtBAS_Institute_Bas_institutedescription ;
      private String gxTv_SdtBAS_Institute_Institutecode ;
      private String gxTv_SdtBAS_Institute_Institutename ;
      private String gxTv_SdtBAS_Institute_Bas_institutecreator ;
      private String gxTv_SdtBAS_Institute_Bas_institutemodifier ;
      private String gxTv_SdtBAS_Institute_Institutecode_Z ;
      private String gxTv_SdtBAS_Institute_Institutename_Z ;
      private String gxTv_SdtBAS_Institute_Bas_institutecreator_Z ;
      private String gxTv_SdtBAS_Institute_Bas_institutemodifier_Z ;
      private String gxTv_SdtBAS_Institute_Bas_institutelogo ;
   }

   [DataContract(Name = @"BAS_Institute", Namespace = "DataAnalysisPlatform")]
   public class SdtBAS_Institute_RESTInterface : GxGenericCollectionItem<SdtBAS_Institute>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBAS_Institute_RESTInterface( ) : base()
      {
      }

      public SdtBAS_Institute_RESTInterface( SdtBAS_Institute psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "InstituteCode" , Order = 0 )]
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

      [DataMember( Name = "InstituteName" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Institutename
      {
         get {
            return sdt.gxTpr_Institutename ;
         }

         set {
            sdt.gxTpr_Institutename = value;
         }

      }

      [DataMember( Name = "BAS_InstituteLogo" , Order = 2 )]
      [GxUpload()]
      public String gxTpr_Bas_institutelogo
      {
         get {
            return PathUtil.RelativeURL( sdt.gxTpr_Bas_institutelogo) ;
         }

         set {
            sdt.gxTpr_Bas_institutelogo = value;
         }

      }

      [DataMember( Name = "BAS_InstituteCreator" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Bas_institutecreator
      {
         get {
            return sdt.gxTpr_Bas_institutecreator ;
         }

         set {
            sdt.gxTpr_Bas_institutecreator = value;
         }

      }

      [DataMember( Name = "BAS_InstituteCreateTime" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Bas_institutecreatetime
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Bas_institutecreatetime) ;
         }

         set {
            sdt.gxTpr_Bas_institutecreatetime = DateTimeUtil.CToT2( value);
         }

      }

      [DataMember( Name = "BAS_InstituteModifier" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Bas_institutemodifier
      {
         get {
            return sdt.gxTpr_Bas_institutemodifier ;
         }

         set {
            sdt.gxTpr_Bas_institutemodifier = value;
         }

      }

      [DataMember( Name = "BAS_InstituteModifyTime" , Order = 6 )]
      [GxSeudo()]
      public String gxTpr_Bas_institutemodifytime
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Bas_institutemodifytime) ;
         }

         set {
            sdt.gxTpr_Bas_institutemodifytime = DateTimeUtil.CToT2( value);
         }

      }

      [DataMember( Name = "BAS_InstituteIsDeleted" , Order = 7 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Bas_instituteisdeleted
      {
         get {
            return sdt.gxTpr_Bas_instituteisdeleted ;
         }

         set {
            sdt.gxTpr_Bas_instituteisdeleted = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "BAS_InstituteDescription" , Order = 8 )]
      public String gxTpr_Bas_institutedescription
      {
         get {
            return sdt.gxTpr_Bas_institutedescription ;
         }

         set {
            sdt.gxTpr_Bas_institutedescription = value;
         }

      }

      public SdtBAS_Institute sdt
      {
         get {
            return (SdtBAS_Institute)Sdt ;
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
            sdt = new SdtBAS_Institute() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 9 )]
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

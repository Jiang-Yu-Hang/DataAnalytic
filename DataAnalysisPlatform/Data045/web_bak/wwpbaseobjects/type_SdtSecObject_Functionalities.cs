/*
               File: wwpbaseobjects.type_SdtSecObject_Functionalities
        Description: Sec Object
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:35:47.32
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
   [XmlRoot(ElementName = "SecObject.Functionalities" )]
   [XmlType(TypeName =  "SecObject.Functionalities" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtSecObject_Functionalities : GxSilentTrnSdt, IGxSilentTrnGridItem
   {
      public SdtSecObject_Functionalities( )
      {
      }

      public SdtSecObject_Functionalities( IGxContext context )
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

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"SecFunctionalityId", typeof(long)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "Functionalities");
         metadata.Set("BT", "SecObjectFunctionalities");
         metadata.Set("PK", "[ \"SecFunctionalityId\" ]");
         metadata.Set("FKList", "[ { \"FK\":[ \"SecFunctionalityId\" ],\"FKMap\":[  ] },{ \"FK\":[ \"SecObjectName\" ],\"FKMap\":[  ] } ]");
         metadata.Set("AllowInsert", "True");
         metadata.Set("AllowUpdate", "True");
         metadata.Set("AllowDelete", "True");
         return metadata ;
      }

      public override GeneXus.Utils.GxStringCollection StateAttributes( )
      {
         GeneXus.Utils.GxStringCollection state = new GeneXus.Utils.GxStringCollection() ;
         state.Add("gxTpr_Mode");
         state.Add("gxTpr_Modified");
         state.Add("gxTpr_Initialized");
         state.Add("gxTpr_Secfunctionalityid_Z");
         state.Add("gxTpr_Secfunctionalitydescription_Z");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         GeneXus.Programs.wwpbaseobjects.SdtSecObject_Functionalities sdt ;
         sdt = (GeneXus.Programs.wwpbaseobjects.SdtSecObject_Functionalities)(source);
         gxTv_SdtSecObject_Functionalities_Secfunctionalityid = sdt.gxTv_SdtSecObject_Functionalities_Secfunctionalityid ;
         gxTv_SdtSecObject_Functionalities_Secfunctionalitydescription = sdt.gxTv_SdtSecObject_Functionalities_Secfunctionalitydescription ;
         gxTv_SdtSecObject_Functionalities_Mode = sdt.gxTv_SdtSecObject_Functionalities_Mode ;
         gxTv_SdtSecObject_Functionalities_Modified = sdt.gxTv_SdtSecObject_Functionalities_Modified ;
         gxTv_SdtSecObject_Functionalities_Initialized = sdt.gxTv_SdtSecObject_Functionalities_Initialized ;
         gxTv_SdtSecObject_Functionalities_Secfunctionalityid_Z = sdt.gxTv_SdtSecObject_Functionalities_Secfunctionalityid_Z ;
         gxTv_SdtSecObject_Functionalities_Secfunctionalitydescription_Z = sdt.gxTv_SdtSecObject_Functionalities_Secfunctionalitydescription_Z ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("SecFunctionalityId", gxTv_SdtSecObject_Functionalities_Secfunctionalityid, false);
         AddObjectProperty("SecFunctionalityDescription", gxTv_SdtSecObject_Functionalities_Secfunctionalitydescription, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtSecObject_Functionalities_Mode, false);
            AddObjectProperty("Modified", gxTv_SdtSecObject_Functionalities_Modified, false);
            AddObjectProperty("Initialized", gxTv_SdtSecObject_Functionalities_Initialized, false);
            AddObjectProperty("SecFunctionalityId_Z", gxTv_SdtSecObject_Functionalities_Secfunctionalityid_Z, false);
            AddObjectProperty("SecFunctionalityDescription_Z", gxTv_SdtSecObject_Functionalities_Secfunctionalitydescription_Z, false);
         }
         return  ;
      }

      public void UpdateDirties( GeneXus.Programs.wwpbaseobjects.SdtSecObject_Functionalities sdt )
      {
         if ( sdt.IsDirty("SecFunctionalityId") )
         {
            gxTv_SdtSecObject_Functionalities_Secfunctionalityid = sdt.gxTv_SdtSecObject_Functionalities_Secfunctionalityid ;
         }
         if ( sdt.IsDirty("SecFunctionalityDescription") )
         {
            gxTv_SdtSecObject_Functionalities_Secfunctionalitydescription = sdt.gxTv_SdtSecObject_Functionalities_Secfunctionalitydescription ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "SecFunctionalityId" )]
      [  XmlElement( ElementName = "SecFunctionalityId"   )]
      public long gxTpr_Secfunctionalityid
      {
         get {
            return gxTv_SdtSecObject_Functionalities_Secfunctionalityid ;
         }

         set {
            gxTv_SdtSecObject_Functionalities_Secfunctionalityid = value;
            gxTv_SdtSecObject_Functionalities_Modified = 1;
            SetDirty("Secfunctionalityid");
         }

      }

      [  SoapElement( ElementName = "SecFunctionalityDescription" )]
      [  XmlElement( ElementName = "SecFunctionalityDescription"   )]
      public String gxTpr_Secfunctionalitydescription
      {
         get {
            return gxTv_SdtSecObject_Functionalities_Secfunctionalitydescription ;
         }

         set {
            gxTv_SdtSecObject_Functionalities_Secfunctionalitydescription = value;
            gxTv_SdtSecObject_Functionalities_Modified = 1;
            SetDirty("Secfunctionalitydescription");
         }

      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtSecObject_Functionalities_Mode ;
         }

         set {
            gxTv_SdtSecObject_Functionalities_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtSecObject_Functionalities_Mode_SetNull( )
      {
         gxTv_SdtSecObject_Functionalities_Mode = "";
         return  ;
      }

      public bool gxTv_SdtSecObject_Functionalities_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Modified" )]
      [  XmlElement( ElementName = "Modified"   )]
      public short gxTpr_Modified
      {
         get {
            return gxTv_SdtSecObject_Functionalities_Modified ;
         }

         set {
            gxTv_SdtSecObject_Functionalities_Modified = value;
            SetDirty("Modified");
         }

      }

      public void gxTv_SdtSecObject_Functionalities_Modified_SetNull( )
      {
         gxTv_SdtSecObject_Functionalities_Modified = 0;
         return  ;
      }

      public bool gxTv_SdtSecObject_Functionalities_Modified_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtSecObject_Functionalities_Initialized ;
         }

         set {
            gxTv_SdtSecObject_Functionalities_Initialized = value;
            gxTv_SdtSecObject_Functionalities_Modified = 1;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtSecObject_Functionalities_Initialized_SetNull( )
      {
         gxTv_SdtSecObject_Functionalities_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtSecObject_Functionalities_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SecFunctionalityId_Z" )]
      [  XmlElement( ElementName = "SecFunctionalityId_Z"   )]
      public long gxTpr_Secfunctionalityid_Z
      {
         get {
            return gxTv_SdtSecObject_Functionalities_Secfunctionalityid_Z ;
         }

         set {
            gxTv_SdtSecObject_Functionalities_Secfunctionalityid_Z = value;
            gxTv_SdtSecObject_Functionalities_Modified = 1;
            SetDirty("Secfunctionalityid_Z");
         }

      }

      public void gxTv_SdtSecObject_Functionalities_Secfunctionalityid_Z_SetNull( )
      {
         gxTv_SdtSecObject_Functionalities_Secfunctionalityid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtSecObject_Functionalities_Secfunctionalityid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SecFunctionalityDescription_Z" )]
      [  XmlElement( ElementName = "SecFunctionalityDescription_Z"   )]
      public String gxTpr_Secfunctionalitydescription_Z
      {
         get {
            return gxTv_SdtSecObject_Functionalities_Secfunctionalitydescription_Z ;
         }

         set {
            gxTv_SdtSecObject_Functionalities_Secfunctionalitydescription_Z = value;
            gxTv_SdtSecObject_Functionalities_Modified = 1;
            SetDirty("Secfunctionalitydescription_Z");
         }

      }

      public void gxTv_SdtSecObject_Functionalities_Secfunctionalitydescription_Z_SetNull( )
      {
         gxTv_SdtSecObject_Functionalities_Secfunctionalitydescription_Z = "";
         return  ;
      }

      public bool gxTv_SdtSecObject_Functionalities_Secfunctionalitydescription_Z_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtSecObject_Functionalities_Secfunctionalitydescription = "";
         gxTv_SdtSecObject_Functionalities_Mode = "";
         gxTv_SdtSecObject_Functionalities_Secfunctionalitydescription_Z = "";
         return  ;
      }

      private short gxTv_SdtSecObject_Functionalities_Modified ;
      private short gxTv_SdtSecObject_Functionalities_Initialized ;
      private long gxTv_SdtSecObject_Functionalities_Secfunctionalityid ;
      private long gxTv_SdtSecObject_Functionalities_Secfunctionalityid_Z ;
      private String gxTv_SdtSecObject_Functionalities_Mode ;
      private String gxTv_SdtSecObject_Functionalities_Secfunctionalitydescription ;
      private String gxTv_SdtSecObject_Functionalities_Secfunctionalitydescription_Z ;
   }

   [DataContract(Name = @"WWPBaseObjects\SecObject.Functionalities", Namespace = "DataAnalysisPlatform")]
   public class SdtSecObject_Functionalities_RESTInterface : GxGenericCollectionItem<GeneXus.Programs.wwpbaseobjects.SdtSecObject_Functionalities>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSecObject_Functionalities_RESTInterface( ) : base()
      {
      }

      public SdtSecObject_Functionalities_RESTInterface( GeneXus.Programs.wwpbaseobjects.SdtSecObject_Functionalities psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "SecFunctionalityId" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Secfunctionalityid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Secfunctionalityid), 10, 0)) ;
         }

         set {
            sdt.gxTpr_Secfunctionalityid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "SecFunctionalityDescription" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Secfunctionalitydescription
      {
         get {
            return sdt.gxTpr_Secfunctionalitydescription ;
         }

         set {
            sdt.gxTpr_Secfunctionalitydescription = value;
         }

      }

      public GeneXus.Programs.wwpbaseobjects.SdtSecObject_Functionalities sdt
      {
         get {
            return (GeneXus.Programs.wwpbaseobjects.SdtSecObject_Functionalities)Sdt ;
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
            sdt = new GeneXus.Programs.wwpbaseobjects.SdtSecObject_Functionalities() ;
         }
      }

   }

}

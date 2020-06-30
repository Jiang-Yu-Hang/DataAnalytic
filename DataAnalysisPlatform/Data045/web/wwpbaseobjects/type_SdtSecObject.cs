/*
               File: wwpbaseobjects.type_SdtSecObject
        Description: Sec Object
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:6:16.1
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
   [XmlRoot(ElementName = "SecObject" )]
   [XmlType(TypeName =  "SecObject" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtSecObject : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSecObject( )
      {
      }

      public SdtSecObject( IGxContext context )
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

      public void Load( String AV5SecObjectName )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(String)AV5SecObjectName});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"SecObjectName", typeof(String)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "WWPBaseObjects\\SecObject");
         metadata.Set("BT", "SecObject");
         metadata.Set("PK", "[ \"SecObjectName\" ]");
         metadata.Set("Levels", "[ \"Functionalities\" ]");
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
         state.Add("gxTpr_Secobjectname_Z");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         GeneXus.Programs.wwpbaseobjects.SdtSecObject sdt ;
         sdt = (GeneXus.Programs.wwpbaseobjects.SdtSecObject)(source);
         gxTv_SdtSecObject_Secobjectname = sdt.gxTv_SdtSecObject_Secobjectname ;
         gxTv_SdtSecObject_Functionalities = sdt.gxTv_SdtSecObject_Functionalities ;
         gxTv_SdtSecObject_Mode = sdt.gxTv_SdtSecObject_Mode ;
         gxTv_SdtSecObject_Initialized = sdt.gxTv_SdtSecObject_Initialized ;
         gxTv_SdtSecObject_Secobjectname_Z = sdt.gxTv_SdtSecObject_Secobjectname_Z ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("SecObjectName", gxTv_SdtSecObject_Secobjectname, false);
         if ( gxTv_SdtSecObject_Functionalities != null )
         {
            AddObjectProperty("Functionalities", gxTv_SdtSecObject_Functionalities, includeState);
         }
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtSecObject_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtSecObject_Initialized, false);
            AddObjectProperty("SecObjectName_Z", gxTv_SdtSecObject_Secobjectname_Z, false);
         }
         return  ;
      }

      public void UpdateDirties( GeneXus.Programs.wwpbaseobjects.SdtSecObject sdt )
      {
         if ( sdt.IsDirty("SecObjectName") )
         {
            gxTv_SdtSecObject_Secobjectname = sdt.gxTv_SdtSecObject_Secobjectname ;
         }
         if ( gxTv_SdtSecObject_Functionalities != null )
         {
            GXBCLevelCollection<GeneXus.Programs.wwpbaseobjects.SdtSecObject_Functionalities> newCollectionFunctionalities = sdt.gxTpr_Functionalities ;
            GeneXus.Programs.wwpbaseobjects.SdtSecObject_Functionalities currItemFunctionalities ;
            GeneXus.Programs.wwpbaseobjects.SdtSecObject_Functionalities newItemFunctionalities ;
            short idx = 1 ;
            while ( idx <= newCollectionFunctionalities.Count )
            {
               newItemFunctionalities = ((GeneXus.Programs.wwpbaseobjects.SdtSecObject_Functionalities)newCollectionFunctionalities.Item(idx));
               currItemFunctionalities = gxTv_SdtSecObject_Functionalities.GetByKey(newItemFunctionalities.gxTpr_Secfunctionalityid);
               if ( StringUtil.StrCmp(currItemFunctionalities.gxTpr_Mode, "UPD") == 0 )
               {
                  currItemFunctionalities.UpdateDirties(newItemFunctionalities);
                  if ( StringUtil.StrCmp(newItemFunctionalities.gxTpr_Mode, "DLT") == 0 )
                  {
                     currItemFunctionalities.gxTpr_Mode = "DLT";
                  }
                  currItemFunctionalities.gxTpr_Modified = 1;
               }
               else
               {
                  gxTv_SdtSecObject_Functionalities.Add(newItemFunctionalities, 0);
               }
               idx = (short)(idx+1);
            }
         }
         return  ;
      }

      [  SoapElement( ElementName = "SecObjectName" )]
      [  XmlElement( ElementName = "SecObjectName"   )]
      public String gxTpr_Secobjectname
      {
         get {
            return gxTv_SdtSecObject_Secobjectname ;
         }

         set {
            if ( StringUtil.StrCmp(gxTv_SdtSecObject_Secobjectname, value) != 0 )
            {
               gxTv_SdtSecObject_Mode = "INS";
               this.gxTv_SdtSecObject_Secobjectname_Z_SetNull( );
               if ( gxTv_SdtSecObject_Functionalities != null )
               {
                  GXBCLevelCollection<GeneXus.Programs.wwpbaseobjects.SdtSecObject_Functionalities> collectionFunctionalities = gxTv_SdtSecObject_Functionalities ;
                  GeneXus.Programs.wwpbaseobjects.SdtSecObject_Functionalities currItemFunctionalities ;
                  short idx = 1 ;
                  while ( idx <= collectionFunctionalities.Count )
                  {
                     currItemFunctionalities = ((GeneXus.Programs.wwpbaseobjects.SdtSecObject_Functionalities)collectionFunctionalities.Item(idx));
                     currItemFunctionalities.gxTpr_Mode = "INS";
                     currItemFunctionalities.gxTpr_Modified = 1;
                     idx = (short)(idx+1);
                  }
               }
            }
            gxTv_SdtSecObject_Secobjectname = value;
            SetDirty("Secobjectname");
         }

      }

      [  SoapElement( ElementName = "Functionalities" )]
      [  XmlArray( ElementName = "Functionalities"  )]
      [  XmlArrayItemAttribute( ElementName= "SecObject.Functionalities"  , IsNullable=false)]
      public GXBCLevelCollection<GeneXus.Programs.wwpbaseobjects.SdtSecObject_Functionalities> gxTpr_Functionalities_GXBCLevelCollection
      {
         get {
            if ( gxTv_SdtSecObject_Functionalities == null )
            {
               gxTv_SdtSecObject_Functionalities = new GXBCLevelCollection<GeneXus.Programs.wwpbaseobjects.SdtSecObject_Functionalities>( context, "SecObject.Functionalities", "DataAnalysisPlatform");
            }
            return gxTv_SdtSecObject_Functionalities ;
         }

         set {
            if ( gxTv_SdtSecObject_Functionalities == null )
            {
               gxTv_SdtSecObject_Functionalities = new GXBCLevelCollection<GeneXus.Programs.wwpbaseobjects.SdtSecObject_Functionalities>( context, "SecObject.Functionalities", "DataAnalysisPlatform");
            }
            gxTv_SdtSecObject_Functionalities = value;
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public GXBCLevelCollection<GeneXus.Programs.wwpbaseobjects.SdtSecObject_Functionalities> gxTpr_Functionalities
      {
         get {
            if ( gxTv_SdtSecObject_Functionalities == null )
            {
               gxTv_SdtSecObject_Functionalities = new GXBCLevelCollection<GeneXus.Programs.wwpbaseobjects.SdtSecObject_Functionalities>( context, "SecObject.Functionalities", "DataAnalysisPlatform");
            }
            return gxTv_SdtSecObject_Functionalities ;
         }

         set {
            gxTv_SdtSecObject_Functionalities = value;
            SetDirty("Functionalities");
         }

      }

      public void gxTv_SdtSecObject_Functionalities_SetNull( )
      {
         gxTv_SdtSecObject_Functionalities = null;
         return  ;
      }

      public bool gxTv_SdtSecObject_Functionalities_IsNull( )
      {
         if ( gxTv_SdtSecObject_Functionalities == null )
         {
            return true ;
         }
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtSecObject_Mode ;
         }

         set {
            gxTv_SdtSecObject_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtSecObject_Mode_SetNull( )
      {
         gxTv_SdtSecObject_Mode = "";
         return  ;
      }

      public bool gxTv_SdtSecObject_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtSecObject_Initialized ;
         }

         set {
            gxTv_SdtSecObject_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtSecObject_Initialized_SetNull( )
      {
         gxTv_SdtSecObject_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtSecObject_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SecObjectName_Z" )]
      [  XmlElement( ElementName = "SecObjectName_Z"   )]
      public String gxTpr_Secobjectname_Z
      {
         get {
            return gxTv_SdtSecObject_Secobjectname_Z ;
         }

         set {
            gxTv_SdtSecObject_Secobjectname_Z = value;
            SetDirty("Secobjectname_Z");
         }

      }

      public void gxTv_SdtSecObject_Secobjectname_Z_SetNull( )
      {
         gxTv_SdtSecObject_Secobjectname_Z = "";
         return  ;
      }

      public bool gxTv_SdtSecObject_Secobjectname_Z_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtSecObject_Secobjectname = "";
         gxTv_SdtSecObject_Mode = "";
         gxTv_SdtSecObject_Secobjectname_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "secobject", "GeneXus.Programs.wwpbaseobjects.secobject_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtSecObject_Initialized ;
      private String gxTv_SdtSecObject_Mode ;
      private String gxTv_SdtSecObject_Secobjectname ;
      private String gxTv_SdtSecObject_Secobjectname_Z ;
      private GXBCLevelCollection<GeneXus.Programs.wwpbaseobjects.SdtSecObject_Functionalities> gxTv_SdtSecObject_Functionalities=null ;
   }

   [DataContract(Name = @"WWPBaseObjects\SecObject", Namespace = "DataAnalysisPlatform")]
   public class SdtSecObject_RESTInterface : GxGenericCollectionItem<GeneXus.Programs.wwpbaseobjects.SdtSecObject>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSecObject_RESTInterface( ) : base()
      {
      }

      public SdtSecObject_RESTInterface( GeneXus.Programs.wwpbaseobjects.SdtSecObject psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "SecObjectName" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Secobjectname
      {
         get {
            return sdt.gxTpr_Secobjectname ;
         }

         set {
            sdt.gxTpr_Secobjectname = value;
         }

      }

      [DataMember( Name = "Functionalities" , Order = 1 )]
      public GxGenericCollection<GeneXus.Programs.wwpbaseobjects.SdtSecObject_Functionalities_RESTInterface> gxTpr_Functionalities
      {
         get {
            return new GxGenericCollection<GeneXus.Programs.wwpbaseobjects.SdtSecObject_Functionalities_RESTInterface>(sdt.gxTpr_Functionalities) ;
         }

         set {
            value.LoadCollection(sdt.gxTpr_Functionalities);
         }

      }

      public GeneXus.Programs.wwpbaseobjects.SdtSecObject sdt
      {
         get {
            return (GeneXus.Programs.wwpbaseobjects.SdtSecObject)Sdt ;
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
            sdt = new GeneXus.Programs.wwpbaseobjects.SdtSecObject() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 2 )]
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

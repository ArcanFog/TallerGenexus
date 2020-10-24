/*
               File: Estudiante
        Description: Estudiante
             Author: GeneXus C# Generator version 16_0_1-129648
       Generated on: 10/17/2020 2:45:57.81
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
using System.Data;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class estudiante : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      protected void INITENV( )
      {
         if ( GxWebError != 0 )
         {
            return  ;
         }
      }

      protected void INITTRN( )
      {
         initialize_properties( ) ;
         entryPointCalled = false;
         gxfirstwebparm = GetNextPar( );
         gxfirstwebparm_bkp = gxfirstwebparm;
         gxfirstwebparm = DecryptAjaxCall( gxfirstwebparm);
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         if ( StringUtil.StrCmp(gxfirstwebparm, "dyncall") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            dyncall( GetNextPar( )) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_11") == 0 )
         {
            A8CarreraId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8CarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(A8CarreraId), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_11( A8CarreraId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxEvt") == 0 )
         {
            setAjaxEventMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxfirstwebparm = GetNextPar( );
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxfullajaxEvt") == 0 )
         {
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxfirstwebparm = GetNextPar( );
         }
         else
         {
            if ( ! IsValidAjaxCall( false) )
            {
               GxWebError = 1;
               return  ;
            }
            gxfirstwebparm = gxfirstwebparm_bkp;
         }
         if ( ! entryPointCalled && ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
         {
            Gx_mode = gxfirstwebparm;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
            {
               AV7EstudianteId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7EstudianteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7EstudianteId), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vESTUDIANTEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7EstudianteId), "ZZZ9"), context));
            }
         }
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
         {
            gxcookieaux = context.SetCookie( "GX_SESSION_ID", Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
         }
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         toggleJsOutput = isJsOutputEnabled( );
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_web_controls( ) ;
         if ( toggleJsOutput )
         {
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_1-129648", 0) ;
            Form.Meta.addItem("description", "Estudiante", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtEstudianteId_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public estudiante( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public estudiante( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           short aP1_EstudianteId )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7EstudianteId = aP1_EstudianteId;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITENV( ) ;
         INITTRN( ) ;
         if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("rwdmasterpage", "GeneXus.Programs.rwdmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,false);
            ValidateSpaRequest();
            MasterPageObj.webExecute();
            if ( ( GxWebError == 0 ) && context.isAjaxRequest( ) )
            {
               enableOutput();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
               }
               if ( ! context.WillRedirect( ) )
               {
                  context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               }
               else
               {
                  if ( context.isAjaxRequest( ) )
                  {
                     disableOutput();
                  }
                  RenderHtmlHeaders( ) ;
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      protected void fix_multi_value_controls( )
      {
      }

      protected void Draw( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! GxWebStd.gx_redirect( context) )
         {
            disable_std_buttons( ) ;
            enableDisable( ) ;
            set_caption( ) ;
            /* Form start */
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "WWAdvancedContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8 col-sm-offset-2", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTitlecontainer_Internalname, 1, 0, "px", 0, "px", "TableTop", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Estudiante", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Estudiante.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            ClassString = "ErrorViewer";
            StyleString = "";
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8 col-sm-offset-2", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divFormcontainer_Internalname, 1, 0, "px", 0, "px", "FormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divToolbarcell_Internalname, 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 col-sm-offset-3 ToolbarCellClass", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "btn-group", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"";
            ClassString = "BtnFirst";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Estudiante.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Estudiante.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Estudiante.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Estudiante.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Select", bttBtn_select_Jsonclick, 5, "Select", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_Estudiante.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellAdvanced", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEstudianteId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtEstudianteId_Internalname, "Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtEstudianteId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A15EstudianteId), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A15EstudianteId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEstudianteId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEstudianteId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Estudiante.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEstudianteNombre_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtEstudianteNombre_Internalname, "Nombre", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtEstudianteNombre_Internalname, StringUtil.RTrim( A18EstudianteNombre), StringUtil.RTrim( context.localUtil.Format( A18EstudianteNombre, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEstudianteNombre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEstudianteNombre_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Estudiante.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+imgEstudianteFoto_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, "", "Foto", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Static Bitmap Variable */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            A19EstudianteFoto_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( A19EstudianteFoto))&&String.IsNullOrEmpty(StringUtil.RTrim( A40000EstudianteFoto_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( A19EstudianteFoto)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A19EstudianteFoto)) ? A40000EstudianteFoto_GXI : context.PathToRelativeUrl( A19EstudianteFoto));
            GxWebStd.gx_bitmap( context, imgEstudianteFoto_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, imgEstudianteFoto_Enabled, "", "", 1, -1, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", "", "", "", 0, A19EstudianteFoto_IsBlob, true, context.GetImageSrcSet( sImgUrl), "HLP_Estudiante.htm");
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgEstudianteFoto_Internalname, "URL", (String.IsNullOrEmpty(StringUtil.RTrim( A19EstudianteFoto)) ? A40000EstudianteFoto_GXI : context.PathToRelativeUrl( A19EstudianteFoto)), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgEstudianteFoto_Internalname, "IsBlob", StringUtil.BoolToStr( A19EstudianteFoto_IsBlob), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEstudianteIngreso_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtEstudianteIngreso_Internalname, "Ingreso", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtEstudianteIngreso_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtEstudianteIngreso_Internalname, context.localUtil.Format(A20EstudianteIngreso, "99/99/99"), context.localUtil.Format( A20EstudianteIngreso, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'MDY',0,12,'eng',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEstudianteIngreso_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEstudianteIngreso_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Estudiante.htm");
            GxWebStd.gx_bitmap( context, edtEstudianteIngreso_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtEstudianteIngreso_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_Estudiante.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtCarreraId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtCarreraId_Internalname, "Carrera Id", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtCarreraId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A8CarreraId), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A8CarreraId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtCarreraId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtCarreraId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_Estudiante.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "prompt.gif", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_8_Internalname, sImgUrl, imgprompt_8_Link, "", "", context.GetTheme( ), imgprompt_8_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Estudiante.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtCarreraNombre_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtCarreraNombre_Internalname, "Carrera Nombre", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtCarreraNombre_Internalname, StringUtil.RTrim( A9CarreraNombre), StringUtil.RTrim( context.localUtil.Format( A9CarreraNombre, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtCarreraNombre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtCarreraNombre_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_Estudiante.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group Confirm", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirm", bttBtn_enter_Jsonclick, 5, "Confirm", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Estudiante.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Estudiante.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Delete", bttBtn_delete_Jsonclick, 5, "Delete", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Estudiante.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void UserMain( )
      {
         standaloneStartup( ) ;
      }

      protected void UserMainFullajax( )
      {
         INITENV( ) ;
         INITTRN( ) ;
         UserMain( ) ;
         Draw( ) ;
         SendCloseFormHiddens( ) ;
      }

      protected void standaloneStartup( )
      {
         standaloneStartupServer( ) ;
         disable_std_buttons( ) ;
         enableDisable( ) ;
         Process( ) ;
      }

      protected void standaloneStartupServer( )
      {
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E11072 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               if ( ( ( context.localUtil.CToN( cgiGet( edtEstudianteId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtEstudianteId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ESTUDIANTEID");
                  AnyError = 1;
                  GX_FocusControl = edtEstudianteId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A15EstudianteId = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15EstudianteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A15EstudianteId), 4, 0)));
               }
               else
               {
                  A15EstudianteId = (short)(context.localUtil.CToN( cgiGet( edtEstudianteId_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15EstudianteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A15EstudianteId), 4, 0)));
               }
               A18EstudianteNombre = cgiGet( edtEstudianteNombre_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18EstudianteNombre", A18EstudianteNombre);
               A19EstudianteFoto = cgiGet( imgEstudianteFoto_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19EstudianteFoto", A19EstudianteFoto);
               if ( context.localUtil.VCDate( cgiGet( edtEstudianteIngreso_Internalname), 1) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Estudiante Ingreso"}), 1, "ESTUDIANTEINGRESO");
                  AnyError = 1;
                  GX_FocusControl = edtEstudianteIngreso_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A20EstudianteIngreso = DateTime.MinValue;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20EstudianteIngreso", context.localUtil.Format(A20EstudianteIngreso, "99/99/99"));
               }
               else
               {
                  A20EstudianteIngreso = context.localUtil.CToD( cgiGet( edtEstudianteIngreso_Internalname), 1);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20EstudianteIngreso", context.localUtil.Format(A20EstudianteIngreso, "99/99/99"));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtCarreraId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtCarreraId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CARRERAID");
                  AnyError = 1;
                  GX_FocusControl = edtCarreraId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A8CarreraId = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8CarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(A8CarreraId), 4, 0)));
               }
               else
               {
                  A8CarreraId = (short)(context.localUtil.CToN( cgiGet( edtCarreraId_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8CarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(A8CarreraId), 4, 0)));
               }
               A9CarreraNombre = cgiGet( edtCarreraNombre_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9CarreraNombre", A9CarreraNombre);
               /* Read saved values. */
               Z15EstudianteId = (short)(context.localUtil.CToN( cgiGet( "Z15EstudianteId"), ".", ","));
               Z18EstudianteNombre = cgiGet( "Z18EstudianteNombre");
               Z20EstudianteIngreso = context.localUtil.CToD( cgiGet( "Z20EstudianteIngreso"), 0);
               Z8CarreraId = (short)(context.localUtil.CToN( cgiGet( "Z8CarreraId"), ".", ","));
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               N8CarreraId = (short)(context.localUtil.CToN( cgiGet( "N8CarreraId"), ".", ","));
               AV7EstudianteId = (short)(context.localUtil.CToN( cgiGet( "vESTUDIANTEID"), ".", ","));
               AV11Insert_CarreraId = (short)(context.localUtil.CToN( cgiGet( "vINSERT_CARRERAID"), ".", ","));
               A40000EstudianteFoto_GXI = cgiGet( "ESTUDIANTEFOTO_GXI");
               AV13Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               getMultimediaValue(imgEstudianteFoto_Internalname, ref  A19EstudianteFoto, ref  A40000EstudianteFoto_GXI);
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "Estudiante";
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV11Insert_CarreraId), "ZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A15EstudianteId != Z15EstudianteId ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("estudiante:[SecurityCheckFailed value for]"+"Insert_CarreraId:"+context.localUtil.Format( (decimal)(AV11Insert_CarreraId), "ZZZ9"));
                  GXUtil.WriteLog("estudiante:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
                  GxWebError = 1;
                  context.HttpContext.Response.StatusDescription = 403.ToString();
                  context.HttpContext.Response.StatusCode = 403;
                  context.WriteHtmlText( "<title>403 Forbidden</title>") ;
                  context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
                  context.WriteHtmlText( "<p /><hr />") ;
                  GXUtil.WriteLog("send_http_error_code " + 403.ToString());
                  AnyError = 1;
                  return  ;
               }
               standaloneNotModal( ) ;
            }
            else
            {
               standaloneNotModal( ) ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
               {
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  A15EstudianteId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15EstudianteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A15EstudianteId), 4, 0)));
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  disable_std_buttons( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
                  {
                     sMode5 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode5;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound5 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_070( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "ESTUDIANTEID");
                        AnyError = 1;
                        GX_FocusControl = edtEstudianteId_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
         }
      }

      protected void Process( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read Transaction buttons. */
            sEvt = cgiGet( "_EventName");
            EvtGridId = cgiGet( "_EventGridId");
            EvtRowId = cgiGet( "_EventRowId");
            if ( StringUtil.Len( sEvt) > 0 )
            {
               sEvtType = StringUtil.Left( sEvt, 1);
               sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1));
               if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
               {
                  if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                  {
                     sEvtType = StringUtil.Right( sEvt, 1);
                     if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                     {
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                        if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Start */
                           E11072 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E12072 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1;
                           if ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 )
                           {
                              btn_enter( ) ;
                           }
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                     }
                     else
                     {
                     }
                  }
                  context.wbHandled = 1;
               }
            }
         }
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E12072 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll075( ) ;
               standaloneNotModal( ) ;
               standaloneModal( ) ;
            }
         }
      }

      public override String ToString( )
      {
         return "" ;
      }

      public GxContentInfo GetContentInfo( )
      {
         return (GxContentInfo)(null) ;
      }

      protected void disable_std_buttons( )
      {
         bttBtn_delete_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)), true);
         bttBtn_first_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_first_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_first_Visible), 5, 0)), true);
         bttBtn_previous_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_previous_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_previous_Visible), 5, 0)), true);
         bttBtn_next_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_next_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_next_Visible), 5, 0)), true);
         bttBtn_last_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_last_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_last_Visible), 5, 0)), true);
         bttBtn_select_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_select_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_select_Visible), 5, 0)), true);
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            bttBtn_delete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)), true);
            if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
            {
               bttBtn_enter_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Visible), 5, 0)), true);
            }
            DisableAttributes075( ) ;
         }
      }

      protected void set_caption( )
      {
         if ( ( IsConfirmed == 1 ) && ( AnyError == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_confdelete", ""), 0, "", true);
            }
            else
            {
               GX_msglist.addItem(context.GetMessage( "GXM_mustconfirm", ""), 0, "", true);
            }
         }
      }

      protected void CONFIRM_070( )
      {
         BeforeValidate075( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls075( ) ;
            }
            else
            {
               CheckExtendedTable075( ) ;
               CloseExtendedTableCursors075( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption070( )
      {
      }

      protected void E11072( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV13Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV13Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV9TrnContext.FromXml(AV10WebSession.Get("TrnContext"), null, "TransactionContext", "UniApp");
         AV11Insert_CarreraId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Insert_CarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11Insert_CarreraId), 4, 0)));
         if ( ( StringUtil.StrCmp(AV9TrnContext.gxTpr_Transactionname, AV13Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV14GXV1 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14GXV1), 8, 0)));
            while ( AV14GXV1 <= AV9TrnContext.gxTpr_Attributes.Count )
            {
               AV12TrnContextAtt = ((SdtTransactionContext_Attribute)AV9TrnContext.gxTpr_Attributes.Item(AV14GXV1));
               if ( StringUtil.StrCmp(AV12TrnContextAtt.gxTpr_Attributename, "CarreraId") == 0 )
               {
                  AV11Insert_CarreraId = (short)(NumberUtil.Val( AV12TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11Insert_CarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11Insert_CarreraId), 4, 0)));
               }
               AV14GXV1 = (int)(AV14GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14GXV1), 8, 0)));
            }
         }
      }

      protected void E12072( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV9TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwestudiante.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM075( short GX_JID )
      {
         if ( ( GX_JID == 10 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z18EstudianteNombre = T00073_A18EstudianteNombre[0];
               Z20EstudianteIngreso = T00073_A20EstudianteIngreso[0];
               Z8CarreraId = T00073_A8CarreraId[0];
            }
            else
            {
               Z18EstudianteNombre = A18EstudianteNombre;
               Z20EstudianteIngreso = A20EstudianteIngreso;
               Z8CarreraId = A8CarreraId;
            }
         }
         if ( GX_JID == -10 )
         {
            Z15EstudianteId = A15EstudianteId;
            Z18EstudianteNombre = A18EstudianteNombre;
            Z19EstudianteFoto = A19EstudianteFoto;
            Z40000EstudianteFoto_GXI = A40000EstudianteFoto_GXI;
            Z20EstudianteIngreso = A20EstudianteIngreso;
            Z8CarreraId = A8CarreraId;
            Z9CarreraNombre = A9CarreraNombre;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_8_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0020.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CARRERAID"+"'), id:'"+"CARRERAID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV7EstudianteId) )
         {
            A15EstudianteId = AV7EstudianteId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15EstudianteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A15EstudianteId), 4, 0)));
         }
         if ( ! (0==AV7EstudianteId) )
         {
            edtEstudianteId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEstudianteId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEstudianteId_Enabled), 5, 0)), true);
         }
         else
         {
            edtEstudianteId_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEstudianteId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEstudianteId_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV7EstudianteId) )
         {
            edtEstudianteId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEstudianteId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEstudianteId_Enabled), 5, 0)), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV11Insert_CarreraId) )
         {
            edtCarreraId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCarreraId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCarreraId_Enabled), 5, 0)), true);
         }
         else
         {
            edtCarreraId_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCarreraId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCarreraId_Enabled), 5, 0)), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV11Insert_CarreraId) )
         {
            A8CarreraId = AV11Insert_CarreraId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8CarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(A8CarreraId), 4, 0)));
         }
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_enter_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Enabled), 5, 0)), true);
         }
         else
         {
            bttBtn_enter_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Enabled), 5, 0)), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            AV13Pgmname = "Estudiante";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Pgmname", AV13Pgmname);
            /* Using cursor T00074 */
            pr_default.execute(2, new Object[] {A8CarreraId});
            A9CarreraNombre = T00074_A9CarreraNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9CarreraNombre", A9CarreraNombre);
            pr_default.close(2);
         }
      }

      protected void Load075( )
      {
         /* Using cursor T00075 */
         pr_default.execute(3, new Object[] {A15EstudianteId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound5 = 1;
            A18EstudianteNombre = T00075_A18EstudianteNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18EstudianteNombre", A18EstudianteNombre);
            A40000EstudianteFoto_GXI = T00075_A40000EstudianteFoto_GXI[0];
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgEstudianteFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A19EstudianteFoto)) ? A40000EstudianteFoto_GXI : context.convertURL( context.PathToRelativeUrl( A19EstudianteFoto))), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgEstudianteFoto_Internalname, "SrcSet", context.GetImageSrcSet( A19EstudianteFoto), true);
            A20EstudianteIngreso = T00075_A20EstudianteIngreso[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20EstudianteIngreso", context.localUtil.Format(A20EstudianteIngreso, "99/99/99"));
            A9CarreraNombre = T00075_A9CarreraNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9CarreraNombre", A9CarreraNombre);
            A8CarreraId = T00075_A8CarreraId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8CarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(A8CarreraId), 4, 0)));
            A19EstudianteFoto = T00075_A19EstudianteFoto[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19EstudianteFoto", A19EstudianteFoto);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgEstudianteFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A19EstudianteFoto)) ? A40000EstudianteFoto_GXI : context.convertURL( context.PathToRelativeUrl( A19EstudianteFoto))), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgEstudianteFoto_Internalname, "SrcSet", context.GetImageSrcSet( A19EstudianteFoto), true);
            ZM075( -10) ;
         }
         pr_default.close(3);
         OnLoadActions075( ) ;
      }

      protected void OnLoadActions075( )
      {
         AV13Pgmname = "Estudiante";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Pgmname", AV13Pgmname);
      }

      protected void CheckExtendedTable075( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV13Pgmname = "Estudiante";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Pgmname", AV13Pgmname);
         if ( ! ( (DateTime.MinValue==A20EstudianteIngreso) || ( A20EstudianteIngreso >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Field Estudiante Ingreso is out of range", "OutOfRange", 1, "ESTUDIANTEINGRESO");
            AnyError = 1;
            GX_FocusControl = edtEstudianteIngreso_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         /* Using cursor T00074 */
         pr_default.execute(2, new Object[] {A8CarreraId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No matching 'Carrera'.", "ForeignKeyNotFound", 1, "CARRERAID");
            AnyError = 1;
            GX_FocusControl = edtCarreraId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A9CarreraNombre = T00074_A9CarreraNombre[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9CarreraNombre", A9CarreraNombre);
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors075( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_11( short A8CarreraId )
      {
         /* Using cursor T00076 */
         pr_default.execute(4, new Object[] {A8CarreraId});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("No matching 'Carrera'.", "ForeignKeyNotFound", 1, "CARRERAID");
            AnyError = 1;
            GX_FocusControl = edtCarreraId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A9CarreraNombre = T00076_A9CarreraNombre[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9CarreraNombre", A9CarreraNombre);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A9CarreraNombre))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(4) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(4);
      }

      protected void GetKey075( )
      {
         /* Using cursor T00077 */
         pr_default.execute(5, new Object[] {A15EstudianteId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound5 = 1;
         }
         else
         {
            RcdFound5 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00073 */
         pr_default.execute(1, new Object[] {A15EstudianteId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM075( 10) ;
            RcdFound5 = 1;
            A15EstudianteId = T00073_A15EstudianteId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15EstudianteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A15EstudianteId), 4, 0)));
            A18EstudianteNombre = T00073_A18EstudianteNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18EstudianteNombre", A18EstudianteNombre);
            A40000EstudianteFoto_GXI = T00073_A40000EstudianteFoto_GXI[0];
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgEstudianteFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A19EstudianteFoto)) ? A40000EstudianteFoto_GXI : context.convertURL( context.PathToRelativeUrl( A19EstudianteFoto))), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgEstudianteFoto_Internalname, "SrcSet", context.GetImageSrcSet( A19EstudianteFoto), true);
            A20EstudianteIngreso = T00073_A20EstudianteIngreso[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20EstudianteIngreso", context.localUtil.Format(A20EstudianteIngreso, "99/99/99"));
            A8CarreraId = T00073_A8CarreraId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8CarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(A8CarreraId), 4, 0)));
            A19EstudianteFoto = T00073_A19EstudianteFoto[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19EstudianteFoto", A19EstudianteFoto);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgEstudianteFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A19EstudianteFoto)) ? A40000EstudianteFoto_GXI : context.convertURL( context.PathToRelativeUrl( A19EstudianteFoto))), true);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgEstudianteFoto_Internalname, "SrcSet", context.GetImageSrcSet( A19EstudianteFoto), true);
            Z15EstudianteId = A15EstudianteId;
            sMode5 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load075( ) ;
            if ( AnyError == 1 )
            {
               RcdFound5 = 0;
               InitializeNonKey075( ) ;
            }
            Gx_mode = sMode5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound5 = 0;
            InitializeNonKey075( ) ;
            sMode5 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey075( ) ;
         if ( RcdFound5 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound5 = 0;
         /* Using cursor T00078 */
         pr_default.execute(6, new Object[] {A15EstudianteId});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( T00078_A15EstudianteId[0] < A15EstudianteId ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( T00078_A15EstudianteId[0] > A15EstudianteId ) ) )
            {
               A15EstudianteId = T00078_A15EstudianteId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15EstudianteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A15EstudianteId), 4, 0)));
               RcdFound5 = 1;
            }
         }
         pr_default.close(6);
      }

      protected void move_previous( )
      {
         RcdFound5 = 0;
         /* Using cursor T00079 */
         pr_default.execute(7, new Object[] {A15EstudianteId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T00079_A15EstudianteId[0] > A15EstudianteId ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T00079_A15EstudianteId[0] < A15EstudianteId ) ) )
            {
               A15EstudianteId = T00079_A15EstudianteId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15EstudianteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A15EstudianteId), 4, 0)));
               RcdFound5 = 1;
            }
         }
         pr_default.close(7);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey075( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtEstudianteId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert075( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound5 == 1 )
            {
               if ( A15EstudianteId != Z15EstudianteId )
               {
                  A15EstudianteId = Z15EstudianteId;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15EstudianteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A15EstudianteId), 4, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "ESTUDIANTEID");
                  AnyError = 1;
                  GX_FocusControl = edtEstudianteId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtEstudianteId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update075( ) ;
                  GX_FocusControl = edtEstudianteId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A15EstudianteId != Z15EstudianteId )
               {
                  /* Insert record */
                  GX_FocusControl = edtEstudianteId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert075( ) ;
                  if ( AnyError == 1 )
                  {
                     GX_FocusControl = "";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "ESTUDIANTEID");
                     AnyError = 1;
                     GX_FocusControl = edtEstudianteId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtEstudianteId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert075( ) ;
                     if ( AnyError == 1 )
                     {
                        GX_FocusControl = "";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
         if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            if ( AnyError == 0 )
            {
               context.nUserReturn = 1;
            }
         }
      }

      protected void btn_delete( )
      {
         if ( A15EstudianteId != Z15EstudianteId )
         {
            A15EstudianteId = Z15EstudianteId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15EstudianteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A15EstudianteId), 4, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "ESTUDIANTEID");
            AnyError = 1;
            GX_FocusControl = edtEstudianteId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtEstudianteId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency075( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00072 */
            pr_default.execute(0, new Object[] {A15EstudianteId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Estudiante"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z18EstudianteNombre, T00072_A18EstudianteNombre[0]) != 0 ) || ( Z20EstudianteIngreso != T00072_A20EstudianteIngreso[0] ) || ( Z8CarreraId != T00072_A8CarreraId[0] ) )
            {
               if ( StringUtil.StrCmp(Z18EstudianteNombre, T00072_A18EstudianteNombre[0]) != 0 )
               {
                  GXUtil.WriteLog("estudiante:[seudo value changed for attri]"+"EstudianteNombre");
                  GXUtil.WriteLogRaw("Old: ",Z18EstudianteNombre);
                  GXUtil.WriteLogRaw("Current: ",T00072_A18EstudianteNombre[0]);
               }
               if ( Z20EstudianteIngreso != T00072_A20EstudianteIngreso[0] )
               {
                  GXUtil.WriteLog("estudiante:[seudo value changed for attri]"+"EstudianteIngreso");
                  GXUtil.WriteLogRaw("Old: ",Z20EstudianteIngreso);
                  GXUtil.WriteLogRaw("Current: ",T00072_A20EstudianteIngreso[0]);
               }
               if ( Z8CarreraId != T00072_A8CarreraId[0] )
               {
                  GXUtil.WriteLog("estudiante:[seudo value changed for attri]"+"CarreraId");
                  GXUtil.WriteLogRaw("Old: ",Z8CarreraId);
                  GXUtil.WriteLogRaw("Current: ",T00072_A8CarreraId[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Estudiante"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert075( )
      {
         BeforeValidate075( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable075( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM075( 0) ;
            CheckOptimisticConcurrency075( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm075( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert075( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000710 */
                     pr_default.execute(8, new Object[] {A15EstudianteId, A18EstudianteNombre, A19EstudianteFoto, A40000EstudianteFoto_GXI, A20EstudianteIngreso, A8CarreraId});
                     pr_default.close(8);
                     dsDefault.SmartCacheProvider.SetUpdated("Estudiante") ;
                     if ( (pr_default.getStatus(8) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption070( ) ;
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
            else
            {
               Load075( ) ;
            }
            EndLevel075( ) ;
         }
         CloseExtendedTableCursors075( ) ;
      }

      protected void Update075( )
      {
         BeforeValidate075( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable075( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency075( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm075( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate075( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000711 */
                     pr_default.execute(9, new Object[] {A18EstudianteNombre, A20EstudianteIngreso, A8CarreraId, A15EstudianteId});
                     pr_default.close(9);
                     dsDefault.SmartCacheProvider.SetUpdated("Estudiante") ;
                     if ( (pr_default.getStatus(9) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Estudiante"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate075( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                           {
                              if ( AnyError == 0 )
                              {
                                 context.nUserReturn = 1;
                              }
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
            EndLevel075( ) ;
         }
         CloseExtendedTableCursors075( ) ;
      }

      protected void DeferredUpdate075( )
      {
         if ( AnyError == 0 )
         {
            /* Using cursor T000712 */
            pr_default.execute(10, new Object[] {A19EstudianteFoto, A40000EstudianteFoto_GXI, A15EstudianteId});
            pr_default.close(10);
            dsDefault.SmartCacheProvider.SetUpdated("Estudiante") ;
         }
      }

      protected void delete( )
      {
         BeforeValidate075( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency075( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls075( ) ;
            AfterConfirm075( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete075( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000713 */
                  pr_default.execute(11, new Object[] {A15EstudianteId});
                  pr_default.close(11);
                  dsDefault.SmartCacheProvider.SetUpdated("Estudiante") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                        {
                           if ( AnyError == 0 )
                           {
                              context.nUserReturn = 1;
                           }
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
         }
         sMode5 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel075( ) ;
         Gx_mode = sMode5;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls075( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV13Pgmname = "Estudiante";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Pgmname", AV13Pgmname);
            /* Using cursor T000714 */
            pr_default.execute(12, new Object[] {A8CarreraId});
            A9CarreraNombre = T000714_A9CarreraNombre[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9CarreraNombre", A9CarreraNombre);
            pr_default.close(12);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000715 */
            pr_default.execute(13, new Object[] {A15EstudianteId});
            if ( (pr_default.getStatus(13) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Estudiiante"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(13);
         }
      }

      protected void EndLevel075( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete075( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_default.close(12);
            context.CommitDataStores("estudiante",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues070( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            pr_default.close(12);
            context.RollbackDataStores("estudiante",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart075( )
      {
         /* Scan By routine */
         /* Using cursor T000716 */
         pr_default.execute(14);
         RcdFound5 = 0;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound5 = 1;
            A15EstudianteId = T000716_A15EstudianteId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15EstudianteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A15EstudianteId), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext075( )
      {
         /* Scan next routine */
         pr_default.readNext(14);
         RcdFound5 = 0;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound5 = 1;
            A15EstudianteId = T000716_A15EstudianteId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15EstudianteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A15EstudianteId), 4, 0)));
         }
      }

      protected void ScanEnd075( )
      {
         pr_default.close(14);
      }

      protected void AfterConfirm075( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert075( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate075( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete075( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete075( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate075( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes075( )
      {
         edtEstudianteId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEstudianteId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEstudianteId_Enabled), 5, 0)), true);
         edtEstudianteNombre_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEstudianteNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEstudianteNombre_Enabled), 5, 0)), true);
         imgEstudianteFoto_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgEstudianteFoto_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgEstudianteFoto_Enabled), 5, 0)), true);
         edtEstudianteIngreso_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEstudianteIngreso_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEstudianteIngreso_Enabled), 5, 0)), true);
         edtCarreraId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCarreraId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCarreraId_Enabled), 5, 0)), true);
         edtCarreraNombre_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCarreraNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCarreraNombre_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes075( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues070( )
      {
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, true);
      }

      public override void RenderHtmlOpenForm( )
      {
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( "<title>") ;
         context.SendWebValue( Form.Caption) ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
         MasterPageObj.master_styles();
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 129648), false, true);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 129648), false, true);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 129648), false, true);
         context.AddJavascriptSource("gxcfg.js", "?202010172455988", false, true);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 129648), false, true);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 129648), false, true);
         context.AddJavascriptSource("calendar-en.js", "?"+context.GetBuildNumber( 129648), false, true);
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"true\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "" + "background-color:" + context.BuildHTMLColor( Form.Backcolor) + ";color:" + context.BuildHTMLColor( Form.Textcolor) + ";";
         bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("estudiante.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7EstudianteId)+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         context.WriteHtmlText( "<input type=\"submit\" title=\"submit\" style=\"display:none\" disabled>") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Class", "form-horizontal Form", true);
         toggleJsOutput = isJsOutputEnabled( );
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
      }

      protected void send_integrity_footer_hashes( )
      {
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         forbiddenHiddens = "hsh" + "Estudiante";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV11Insert_CarreraId), "ZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("estudiante:[SendSecurityCheck value for]"+"Insert_CarreraId:"+context.localUtil.Format( (decimal)(AV11Insert_CarreraId), "ZZZ9"));
         GXUtil.WriteLog("estudiante:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z15EstudianteId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z15EstudianteId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z18EstudianteNombre", StringUtil.RTrim( Z18EstudianteNombre));
         GxWebStd.gx_hidden_field( context, "Z20EstudianteIngreso", context.localUtil.DToC( Z20EstudianteIngreso, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z8CarreraId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z8CarreraId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "N8CarreraId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A8CarreraId), 4, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV9TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vESTUDIANTEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7EstudianteId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vESTUDIANTEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7EstudianteId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_CARRERAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11Insert_CarreraId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "ESTUDIANTEFOTO_GXI", A40000EstudianteFoto_GXI);
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV13Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GXCCtlgxBlob = "ESTUDIANTEFOTO" + "_gxBlob";
         GxWebStd.gx_hidden_field( context, GXCCtlgxBlob, A19EstudianteFoto);
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendSecurityToken(sPrefix);
         SendComponentObjects();
         SendServerCommands();
         SendState();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         context.WriteHtmlTextNl( "</form>") ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         include_jscripts( ) ;
      }

      public override short ExecuteStartEvent( )
      {
         standaloneStartup( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         return gxajaxcallmode ;
      }

      public override void RenderHtmlContent( )
      {
         context.WriteHtmlText( "<div") ;
         GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
         context.WriteHtmlText( ">") ;
         Draw( ) ;
         context.WriteHtmlText( "</div>") ;
      }

      public override void DispatchEvents( )
      {
         Process( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("estudiante.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7EstudianteId) ;
      }

      public override String GetPgmname( )
      {
         return "Estudiante" ;
      }

      public override String GetPgmdesc( )
      {
         return "Estudiante" ;
      }

      protected void InitializeNonKey075( )
      {
         A8CarreraId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8CarreraId", StringUtil.LTrim( StringUtil.Str( (decimal)(A8CarreraId), 4, 0)));
         A18EstudianteNombre = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18EstudianteNombre", A18EstudianteNombre);
         A19EstudianteFoto = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19EstudianteFoto", A19EstudianteFoto);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgEstudianteFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A19EstudianteFoto)) ? A40000EstudianteFoto_GXI : context.convertURL( context.PathToRelativeUrl( A19EstudianteFoto))), true);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgEstudianteFoto_Internalname, "SrcSet", context.GetImageSrcSet( A19EstudianteFoto), true);
         A40000EstudianteFoto_GXI = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgEstudianteFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A19EstudianteFoto)) ? A40000EstudianteFoto_GXI : context.convertURL( context.PathToRelativeUrl( A19EstudianteFoto))), true);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgEstudianteFoto_Internalname, "SrcSet", context.GetImageSrcSet( A19EstudianteFoto), true);
         A20EstudianteIngreso = DateTime.MinValue;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20EstudianteIngreso", context.localUtil.Format(A20EstudianteIngreso, "99/99/99"));
         A9CarreraNombre = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9CarreraNombre", A9CarreraNombre);
         Z18EstudianteNombre = "";
         Z20EstudianteIngreso = DateTime.MinValue;
         Z8CarreraId = 0;
      }

      protected void InitAll075( )
      {
         A15EstudianteId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15EstudianteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A15EstudianteId), 4, 0)));
         InitializeNonKey075( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "");
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2020101724604", true, true);
            idxLst = (int)(idxLst+1);
         }
         if ( ! outputEnabled )
         {
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.eng.js", "?"+GetCacheInvalidationToken( ), false, true);
         context.AddJavascriptSource("estudiante.js", "?2020101724605", false, true);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTitle_Internalname = "TITLE";
         divTitlecontainer_Internalname = "TITLECONTAINER";
         bttBtn_first_Internalname = "BTN_FIRST";
         bttBtn_previous_Internalname = "BTN_PREVIOUS";
         bttBtn_next_Internalname = "BTN_NEXT";
         bttBtn_last_Internalname = "BTN_LAST";
         bttBtn_select_Internalname = "BTN_SELECT";
         divToolbarcell_Internalname = "TOOLBARCELL";
         edtEstudianteId_Internalname = "ESTUDIANTEID";
         edtEstudianteNombre_Internalname = "ESTUDIANTENOMBRE";
         imgEstudianteFoto_Internalname = "ESTUDIANTEFOTO";
         edtEstudianteIngreso_Internalname = "ESTUDIANTEINGRESO";
         edtCarreraId_Internalname = "CARRERAID";
         edtCarreraNombre_Internalname = "CARRERANOMBRE";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_8_Internalname = "PROMPT_8";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Estudiante";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtCarreraNombre_Jsonclick = "";
         edtCarreraNombre_Enabled = 0;
         imgprompt_8_Visible = 1;
         imgprompt_8_Link = "";
         edtCarreraId_Jsonclick = "";
         edtCarreraId_Enabled = 1;
         edtEstudianteIngreso_Jsonclick = "";
         edtEstudianteIngreso_Enabled = 1;
         imgEstudianteFoto_Enabled = 1;
         edtEstudianteNombre_Jsonclick = "";
         edtEstudianteNombre_Enabled = 1;
         edtEstudianteId_Jsonclick = "";
         edtEstudianteId_Enabled = 1;
         bttBtn_select_Visible = 1;
         bttBtn_last_Visible = 1;
         bttBtn_next_Visible = 1;
         bttBtn_previous_Visible = 1;
         bttBtn_first_Visible = 1;
         context.GX_msglist.DisplayMode = 1;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      public void Valid_Carreraid( short GX_Parm1 ,
                                   String GX_Parm2 )
      {
         A8CarreraId = GX_Parm1;
         A9CarreraNombre = GX_Parm2;
         /* Using cursor T000714 */
         pr_default.execute(12, new Object[] {A8CarreraId});
         if ( (pr_default.getStatus(12) == 101) )
         {
            GX_msglist.addItem("No matching 'Carrera'.", "ForeignKeyNotFound", 1, "CARRERAID");
            AnyError = 1;
            GX_FocusControl = edtCarreraId_Internalname;
         }
         A9CarreraNombre = T000714_A9CarreraNombre[0];
         pr_default.close(12);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A9CarreraNombre = "";
         }
         isValidOutput.Add(StringUtil.RTrim( A9CarreraNombre));
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7EstudianteId',fld:'vESTUDIANTEID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7EstudianteId',fld:'vESTUDIANTEID',pic:'ZZZ9',hsh:true},{av:'AV11Insert_CarreraId',fld:'vINSERT_CARRERAID',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12072',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:''}]");
         setEventMetadata("AFTER TRN",",oparms:[]}");
         return  ;
      }

      public override void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
         pr_default.close(1);
         pr_default.close(12);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z18EstudianteNombre = "";
         Z20EstudianteIngreso = DateTime.MinValue;
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         lblTitle_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         TempTags = "";
         bttBtn_first_Jsonclick = "";
         bttBtn_previous_Jsonclick = "";
         bttBtn_next_Jsonclick = "";
         bttBtn_last_Jsonclick = "";
         bttBtn_select_Jsonclick = "";
         A18EstudianteNombre = "";
         A19EstudianteFoto = "";
         A40000EstudianteFoto_GXI = "";
         sImgUrl = "";
         A20EstudianteIngreso = DateTime.MinValue;
         A9CarreraNombre = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         AV13Pgmname = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode5 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV9TrnContext = new SdtTransactionContext(context);
         AV10WebSession = context.GetSession();
         AV12TrnContextAtt = new SdtTransactionContext_Attribute(context);
         Z19EstudianteFoto = "";
         Z40000EstudianteFoto_GXI = "";
         Z9CarreraNombre = "";
         T00074_A9CarreraNombre = new String[] {""} ;
         T00075_A15EstudianteId = new short[1] ;
         T00075_A18EstudianteNombre = new String[] {""} ;
         T00075_A40000EstudianteFoto_GXI = new String[] {""} ;
         T00075_A20EstudianteIngreso = new DateTime[] {DateTime.MinValue} ;
         T00075_A9CarreraNombre = new String[] {""} ;
         T00075_A8CarreraId = new short[1] ;
         T00075_A19EstudianteFoto = new String[] {""} ;
         T00076_A9CarreraNombre = new String[] {""} ;
         T00077_A15EstudianteId = new short[1] ;
         T00073_A15EstudianteId = new short[1] ;
         T00073_A18EstudianteNombre = new String[] {""} ;
         T00073_A40000EstudianteFoto_GXI = new String[] {""} ;
         T00073_A20EstudianteIngreso = new DateTime[] {DateTime.MinValue} ;
         T00073_A8CarreraId = new short[1] ;
         T00073_A19EstudianteFoto = new String[] {""} ;
         T00078_A15EstudianteId = new short[1] ;
         T00079_A15EstudianteId = new short[1] ;
         T00072_A15EstudianteId = new short[1] ;
         T00072_A18EstudianteNombre = new String[] {""} ;
         T00072_A40000EstudianteFoto_GXI = new String[] {""} ;
         T00072_A20EstudianteIngreso = new DateTime[] {DateTime.MinValue} ;
         T00072_A8CarreraId = new short[1] ;
         T00072_A19EstudianteFoto = new String[] {""} ;
         T000714_A9CarreraNombre = new String[] {""} ;
         T000715_A17ExamenId = new short[1] ;
         T000715_A15EstudianteId = new short[1] ;
         T000716_A15EstudianteId = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXCCtlgxBlob = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.estudiante__default(),
            new Object[][] {
                new Object[] {
               T00072_A15EstudianteId, T00072_A18EstudianteNombre, T00072_A40000EstudianteFoto_GXI, T00072_A20EstudianteIngreso, T00072_A8CarreraId, T00072_A19EstudianteFoto
               }
               , new Object[] {
               T00073_A15EstudianteId, T00073_A18EstudianteNombre, T00073_A40000EstudianteFoto_GXI, T00073_A20EstudianteIngreso, T00073_A8CarreraId, T00073_A19EstudianteFoto
               }
               , new Object[] {
               T00074_A9CarreraNombre
               }
               , new Object[] {
               T00075_A15EstudianteId, T00075_A18EstudianteNombre, T00075_A40000EstudianteFoto_GXI, T00075_A20EstudianteIngreso, T00075_A9CarreraNombre, T00075_A8CarreraId, T00075_A19EstudianteFoto
               }
               , new Object[] {
               T00076_A9CarreraNombre
               }
               , new Object[] {
               T00077_A15EstudianteId
               }
               , new Object[] {
               T00078_A15EstudianteId
               }
               , new Object[] {
               T00079_A15EstudianteId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000714_A9CarreraNombre
               }
               , new Object[] {
               T000715_A17ExamenId, T000715_A15EstudianteId
               }
               , new Object[] {
               T000716_A15EstudianteId
               }
            }
         );
         AV13Pgmname = "Estudiante";
      }

      private short wcpOAV7EstudianteId ;
      private short Z15EstudianteId ;
      private short Z8CarreraId ;
      private short N8CarreraId ;
      private short GxWebError ;
      private short A8CarreraId ;
      private short AV7EstudianteId ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A15EstudianteId ;
      private short AV11Insert_CarreraId ;
      private short RcdFound5 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtEstudianteId_Enabled ;
      private int edtEstudianteNombre_Enabled ;
      private int imgEstudianteFoto_Enabled ;
      private int edtEstudianteIngreso_Enabled ;
      private int edtCarreraId_Enabled ;
      private int imgprompt_8_Visible ;
      private int edtCarreraNombre_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int AV14GXV1 ;
      private int idxLst ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String Z18EstudianteNombre ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtEstudianteId_Internalname ;
      private String divMaintable_Internalname ;
      private String divTitlecontainer_Internalname ;
      private String lblTitle_Internalname ;
      private String lblTitle_Jsonclick ;
      private String ClassString ;
      private String StyleString ;
      private String divFormcontainer_Internalname ;
      private String divToolbarcell_Internalname ;
      private String TempTags ;
      private String bttBtn_first_Internalname ;
      private String bttBtn_first_Jsonclick ;
      private String bttBtn_previous_Internalname ;
      private String bttBtn_previous_Jsonclick ;
      private String bttBtn_next_Internalname ;
      private String bttBtn_next_Jsonclick ;
      private String bttBtn_last_Internalname ;
      private String bttBtn_last_Jsonclick ;
      private String bttBtn_select_Internalname ;
      private String bttBtn_select_Jsonclick ;
      private String edtEstudianteId_Jsonclick ;
      private String edtEstudianteNombre_Internalname ;
      private String A18EstudianteNombre ;
      private String edtEstudianteNombre_Jsonclick ;
      private String imgEstudianteFoto_Internalname ;
      private String sImgUrl ;
      private String edtEstudianteIngreso_Internalname ;
      private String edtEstudianteIngreso_Jsonclick ;
      private String edtCarreraId_Internalname ;
      private String edtCarreraId_Jsonclick ;
      private String imgprompt_8_Internalname ;
      private String imgprompt_8_Link ;
      private String edtCarreraNombre_Internalname ;
      private String A9CarreraNombre ;
      private String edtCarreraNombre_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String AV13Pgmname ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode5 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String Z9CarreraNombre ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXCCtlgxBlob ;
      private DateTime Z20EstudianteIngreso ;
      private DateTime A20EstudianteIngreso ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool A19EstudianteFoto_IsBlob ;
      private bool returnInSub ;
      private String A40000EstudianteFoto_GXI ;
      private String Z40000EstudianteFoto_GXI ;
      private String A19EstudianteFoto ;
      private String Z19EstudianteFoto ;
      private IGxSession AV10WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T00074_A9CarreraNombre ;
      private short[] T00075_A15EstudianteId ;
      private String[] T00075_A18EstudianteNombre ;
      private String[] T00075_A40000EstudianteFoto_GXI ;
      private DateTime[] T00075_A20EstudianteIngreso ;
      private String[] T00075_A9CarreraNombre ;
      private short[] T00075_A8CarreraId ;
      private String[] T00075_A19EstudianteFoto ;
      private String[] T00076_A9CarreraNombre ;
      private short[] T00077_A15EstudianteId ;
      private short[] T00073_A15EstudianteId ;
      private String[] T00073_A18EstudianteNombre ;
      private String[] T00073_A40000EstudianteFoto_GXI ;
      private DateTime[] T00073_A20EstudianteIngreso ;
      private short[] T00073_A8CarreraId ;
      private String[] T00073_A19EstudianteFoto ;
      private short[] T00078_A15EstudianteId ;
      private short[] T00079_A15EstudianteId ;
      private short[] T00072_A15EstudianteId ;
      private String[] T00072_A18EstudianteNombre ;
      private String[] T00072_A40000EstudianteFoto_GXI ;
      private DateTime[] T00072_A20EstudianteIngreso ;
      private short[] T00072_A8CarreraId ;
      private String[] T00072_A19EstudianteFoto ;
      private String[] T000714_A9CarreraNombre ;
      private short[] T000715_A17ExamenId ;
      private short[] T000715_A15EstudianteId ;
      private short[] T000716_A15EstudianteId ;
      private GXWebForm Form ;
      private SdtTransactionContext AV9TrnContext ;
      private SdtTransactionContext_Attribute AV12TrnContextAtt ;
   }

   public class estudiante__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new ForEachCursor(def[6])
         ,new ForEachCursor(def[7])
         ,new UpdateCursor(def[8])
         ,new UpdateCursor(def[9])
         ,new UpdateCursor(def[10])
         ,new UpdateCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00075 ;
          prmT00075 = new Object[] {
          new Object[] {"@EstudianteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00074 ;
          prmT00074 = new Object[] {
          new Object[] {"@CarreraId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00076 ;
          prmT00076 = new Object[] {
          new Object[] {"@CarreraId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00077 ;
          prmT00077 = new Object[] {
          new Object[] {"@EstudianteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00073 ;
          prmT00073 = new Object[] {
          new Object[] {"@EstudianteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00078 ;
          prmT00078 = new Object[] {
          new Object[] {"@EstudianteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00079 ;
          prmT00079 = new Object[] {
          new Object[] {"@EstudianteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00072 ;
          prmT00072 = new Object[] {
          new Object[] {"@EstudianteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000710 ;
          prmT000710 = new Object[] {
          new Object[] {"@EstudianteId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EstudianteNombre",SqlDbType.Char,20,0} ,
          new Object[] {"@EstudianteFoto",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@EstudianteFoto_GXI",SqlDbType.VarChar,2048,0} ,
          new Object[] {"@EstudianteIngreso",SqlDbType.DateTime,8,0} ,
          new Object[] {"@CarreraId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000711 ;
          prmT000711 = new Object[] {
          new Object[] {"@EstudianteNombre",SqlDbType.Char,20,0} ,
          new Object[] {"@EstudianteIngreso",SqlDbType.DateTime,8,0} ,
          new Object[] {"@CarreraId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EstudianteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000712 ;
          prmT000712 = new Object[] {
          new Object[] {"@EstudianteFoto",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@EstudianteFoto_GXI",SqlDbType.VarChar,2048,0} ,
          new Object[] {"@EstudianteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000713 ;
          prmT000713 = new Object[] {
          new Object[] {"@EstudianteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000715 ;
          prmT000715 = new Object[] {
          new Object[] {"@EstudianteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000716 ;
          prmT000716 = new Object[] {
          } ;
          Object[] prmT000714 ;
          prmT000714 = new Object[] {
          new Object[] {"@CarreraId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00072", "SELECT [EstudianteId], [EstudianteNombre], [EstudianteFoto_GXI], [EstudianteIngreso], [CarreraId], [EstudianteFoto] FROM [Estudiante] WITH (UPDLOCK) WHERE [EstudianteId] = @EstudianteId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00072,1,0,true,false )
             ,new CursorDef("T00073", "SELECT [EstudianteId], [EstudianteNombre], [EstudianteFoto_GXI], [EstudianteIngreso], [CarreraId], [EstudianteFoto] FROM [Estudiante] WITH (NOLOCK) WHERE [EstudianteId] = @EstudianteId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00073,1,0,true,false )
             ,new CursorDef("T00074", "SELECT [CarreraNombre] FROM [Carrera] WITH (NOLOCK) WHERE [CarreraId] = @CarreraId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00074,1,0,true,false )
             ,new CursorDef("T00075", "SELECT TM1.[EstudianteId], TM1.[EstudianteNombre], TM1.[EstudianteFoto_GXI], TM1.[EstudianteIngreso], T2.[CarreraNombre], TM1.[CarreraId], TM1.[EstudianteFoto] FROM ([Estudiante] TM1 WITH (NOLOCK) INNER JOIN [Carrera] T2 WITH (NOLOCK) ON T2.[CarreraId] = TM1.[CarreraId]) WHERE TM1.[EstudianteId] = @EstudianteId ORDER BY TM1.[EstudianteId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00075,100,0,true,false )
             ,new CursorDef("T00076", "SELECT [CarreraNombre] FROM [Carrera] WITH (NOLOCK) WHERE [CarreraId] = @CarreraId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00076,1,0,true,false )
             ,new CursorDef("T00077", "SELECT [EstudianteId] FROM [Estudiante] WITH (NOLOCK) WHERE [EstudianteId] = @EstudianteId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00077,1,0,true,false )
             ,new CursorDef("T00078", "SELECT TOP 1 [EstudianteId] FROM [Estudiante] WITH (NOLOCK) WHERE ( [EstudianteId] > @EstudianteId) ORDER BY [EstudianteId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00078,1,0,true,true )
             ,new CursorDef("T00079", "SELECT TOP 1 [EstudianteId] FROM [Estudiante] WITH (NOLOCK) WHERE ( [EstudianteId] < @EstudianteId) ORDER BY [EstudianteId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00079,1,0,true,true )
             ,new CursorDef("T000710", "INSERT INTO [Estudiante]([EstudianteId], [EstudianteNombre], [EstudianteFoto], [EstudianteFoto_GXI], [EstudianteIngreso], [CarreraId]) VALUES(@EstudianteId, @EstudianteNombre, @EstudianteFoto, @EstudianteFoto_GXI, @EstudianteIngreso, @CarreraId)", GxErrorMask.GX_NOMASK,prmT000710)
             ,new CursorDef("T000711", "UPDATE [Estudiante] SET [EstudianteNombre]=@EstudianteNombre, [EstudianteIngreso]=@EstudianteIngreso, [CarreraId]=@CarreraId  WHERE [EstudianteId] = @EstudianteId", GxErrorMask.GX_NOMASK,prmT000711)
             ,new CursorDef("T000712", "UPDATE [Estudiante] SET [EstudianteFoto]=@EstudianteFoto, [EstudianteFoto_GXI]=@EstudianteFoto_GXI  WHERE [EstudianteId] = @EstudianteId", GxErrorMask.GX_NOMASK,prmT000712)
             ,new CursorDef("T000713", "DELETE FROM [Estudiante]  WHERE [EstudianteId] = @EstudianteId", GxErrorMask.GX_NOMASK,prmT000713)
             ,new CursorDef("T000714", "SELECT [CarreraNombre] FROM [Carrera] WITH (NOLOCK) WHERE [CarreraId] = @CarreraId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000714,1,0,true,false )
             ,new CursorDef("T000715", "SELECT TOP 1 [ExamenId], [EstudianteId] FROM [ExamenEstudiiante] WITH (NOLOCK) WHERE [EstudianteId] = @EstudianteId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000715,1,0,true,true )
             ,new CursorDef("T000716", "SELECT [EstudianteId] FROM [Estudiante] WITH (NOLOCK) ORDER BY [EstudianteId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000716,100,0,true,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getMultimediaUri(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getMultimediaFile(6, rslt.getVarchar(3)) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getMultimediaUri(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getMultimediaFile(6, rslt.getVarchar(3)) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getMultimediaUri(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((String[]) buf[6])[0] = rslt.getMultimediaFile(7, rslt.getVarchar(3)) ;
                return;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 7 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 12 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                return;
             case 13 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 14 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameterBlob(3, (String)parms[2], false);
                stmt.SetParameterMultimedia(4, (String)parms[3], (String)parms[2], "Estudiante", "EstudianteFoto");
                stmt.SetParameter(5, (DateTime)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                return;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (DateTime)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 10 :
                stmt.SetParameterBlob(1, (String)parms[0], false);
                stmt.SetParameterMultimedia(2, (String)parms[1], (String)parms[0], "Estudiante", "EstudianteFoto");
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 13 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}

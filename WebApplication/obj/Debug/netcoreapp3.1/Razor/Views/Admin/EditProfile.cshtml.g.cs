#pragma checksum "C:\Users\landi\OneDrive\Робочий стіл\WebApplication\Views\Admin\EditProfile.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7c692e714bc534a75b0cfb61bdb917d3da2fd1b012bed0c3cd3c481b8a55b8e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_EditProfile), @"mvc.1.0.view", @"/Views/Admin/EditProfile.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\landi\OneDrive\Робочий стіл\WebApplication\Views\_ViewImports.cshtml"
using WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\landi\OneDrive\Робочий стіл\WebApplication\Views\_ViewImports.cshtml"
using WebApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\landi\OneDrive\Робочий стіл\WebApplication\Views\Admin\EditProfile.cshtml"
using WebApplication.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"7c692e714bc534a75b0cfb61bdb917d3da2fd1b012bed0c3cd3c481b8a55b8e0", @"/Views/Admin/EditProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"826d6d67bfb07340f826fdcd9b017420c34238301f9f067fcbd1af62ab9f1b31", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_EditProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("kt_ecommerce_settings_general_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UploadAvatar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateProfileInfo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\landi\OneDrive\Робочий стіл\WebApplication\Views\Admin\EditProfile.cshtml"
   var userInfo = Model as UserInfo; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""kt_content_container"" class=""container-xxl"">
    <div class=""card mb-5 mb-xl-10"">
        <div class=""card-body pt-9 pb-0"">
            <div class=""d-flex flex-wrap flex-sm-nowrap mb-3"">
                <div class=""me-7 mb-4"">
                    <!--begin::Form-->
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c692e714bc534a75b0cfb61bdb917d3da2fd1b012bed0c3cd3c481b8a55b8e06422", async() => {
                WriteLiteral(@"
                        <!--begin::Input group-->
                        <div class=""mb-7"">
                            <!--begin::Label-->
                            <label class=""fs-6 fw-semibold mb-3"">
                                <span>Update Avatar</span>
                                <i class=""fas fa-exclamation-circle ms-1 fs-7"" data-bs-toggle=""tooltip"" title=""Allowed file types: png, jpg, jpeg.""></i>
                            </label>
                            <!--end::Label-->
                            <!--begin::Image input wrapper-->
                            <div class=""mt-1"">
                                <!--begin::Image placeholder-->
                                <style>
                                    .image-input-placeholder {
                                        background-image: url('admin/media/svg/files/blank-image.svg');
                                    }

                                    [data-theme=""dark""] .image-input-placeholder {
                   ");
                WriteLiteral(@"                     background-image: url('admin/media/svg/files/blank-image-dark.svg');
                                    }
                                </style>
                                <!--end::Image placeholder-->
                                <!--begin::Image input-->
                                <div class=""image-input image-input-outline image-input-placeholder image-input-empty image-input-empty"" data-kt-image-input=""true"">
                                    <!--begin::Preview existing avatar-->
                                    <div class=""image-input-wrapper w-100px h-100px""");
                BeginWriteAttribute("style", " style=\"", 2154, "\"", 2203, 4);
                WriteAttributeValue("", 2162, "background-image:", 2162, 17, true);
                WriteAttributeValue(" ", 2179, "url(\'", 2180, 6, true);
#nullable restore
#line 35 "C:\Users\landi\OneDrive\Робочий стіл\WebApplication\Views\Admin\EditProfile.cshtml"
WriteAttributeValue("", 2185, userInfo.Avatar, 2185, 16, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2201, "\')", 2201, 2, true);
                EndWriteAttribute();
                WriteLiteral(@"></div>
                                    <!--end::Preview existing avatar-->
                                    <!--begin::Edit-->
                                    <label class=""btn btn-icon btn-circle btn-active-color-primary w-25px h-25px bg-body shadow"" data-kt-image-input-action=""change"" data-bs-toggle=""tooltip"" title=""Change avatar"">
                                        <i class=""bi bi-pencil-fill fs-7""></i>
                                        <!--begin::Inputs-->
                                        <input type=""file"" name=""avatar"" accept="".png, .jpg, .jpeg"" />
                                        <input type=""hidden"" name=""avatar_remove"" />
                                        <!--end::Inputs-->
                                    </label>
                                    <!--end::Edit-->
                                    <!--begin::Cancel-->
                                    <span class=""btn btn-icon btn-circle btn-active-color-primary w-25px h-25px bg-body shadow"" data-k");
                WriteLiteral(@"t-image-input-action=""cancel"" data-bs-toggle=""tooltip"" title=""Cancel avatar"">
                                        <i class=""bi bi-x fs-2""></i>
                                    </span>
                                    <!--end::Cancel-->
                                    <!--begin::Remove-->
                                    <span class=""btn btn-icon btn-circle btn-active-color-primary w-25px h-25px bg-body shadow"" data-kt-image-input-action=""remove"" data-bs-toggle=""tooltip"" title=""Remove avatar"">
                                        <i class=""bi bi-x fs-2""></i>
                                    </span>
                                    <!--end::Remove-->
                                </div>
                                <!--end::Image input-->
                            </div>
                            <!--end::Image input wrapper-->
                        </div>
                        <!--end::Input group-->
                        <!--begin::Separator-->
                        ");
                WriteLiteral(@"<div class=""separator mb-6""></div>
                        <!--end::Separator-->
                        <!--begin::Action buttons-->
                        <div class=""d-flex justify-content-end"">
                            <!--begin::Button-->
                            <button type=""submit"" data-kt-contacts-type=""submit"" class=""btn btn-primary"">
                                <span class=""indicator-label"">Update</span>
                                <span class=""indicator-progress"">
                                    Please wait...
                                    <span class=""spinner-border spinner-border-sm align-middle ms-2""></span>
                                </span>
                            </button>
                            <!--end::Button-->
                        </div>
                        <!--end::Action buttons-->
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <!--end::Form-->
                </div>
                <div class=""flex-grow-1"">
                    <div class=""d-flex justify-content-between align-items-start flex-wrap mb-2"">
                        <div class=""d-flex flex-column"">
                            <div class=""d-flex align-items-center mb-2"">
                                <a href=""#"" class=""text-gray-900 text-hover-primary fs-2 fw-bold me-1"">");
#nullable restore
#line 85 "C:\Users\landi\OneDrive\Робочий стіл\WebApplication\Views\Admin\EditProfile.cshtml"
                                                                                                  Write(userInfo.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 85 "C:\Users\landi\OneDrive\Робочий стіл\WebApplication\Views\Admin\EditProfile.cshtml"
                                                                                                                 Write(userInfo.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                <a href=""#"">
                                    <span class=""svg-icon svg-icon-1 svg-icon-primary"">
                                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""24px"" height=""24px"" viewBox=""0 0 24 24"">
                                            <path d=""M10.0813 3.7242C10.8849 2.16438 13.1151 2.16438 13.9187 3.7242V3.7242C14.4016 4.66147 15.4909 5.1127 16.4951 4.79139V4.79139C18.1663 4.25668 19.7433 5.83365 19.2086 7.50485V7.50485C18.8873 8.50905 19.3385 9.59842 20.2758 10.0813V10.0813C21.8356 10.8849 21.8356 13.1151 20.2758 13.9187V13.9187C19.3385 14.4016 18.8873 15.491 19.2086 16.4951V16.4951C19.7433 18.1663 18.1663 19.7433 16.4951 19.2086V19.2086C15.491 18.8873 14.4016 19.3385 13.9187 20.2758V20.2758C13.1151 21.8356 10.8849 21.8356 10.0813 20.2758V20.2758C9.59842 19.3385 8.50905 18.8873 7.50485 19.2086V19.2086C5.83365 19.7433 4.25668 18.1663 4.79139 16.4951V16.4951C5.1127 15.491 4.66147 14.4016 3.7242 13.9187V13.9187C2.16438 13.1151 2.16438 1");
            WriteLiteral(@"0.8849 3.7242 10.0813V10.0813C4.66147 9.59842 5.1127 8.50905 4.79139 7.50485V7.50485C4.25668 5.83365 5.83365 4.25668 7.50485 4.79139V4.79139C8.50905 5.1127 9.59842 4.66147 10.0813 3.7242V3.7242Z"" fill=""currentColor"" />
                                            <path d=""M14.8563 9.1903C15.0606 8.94984 15.3771 8.9385 15.6175 9.14289C15.858 9.34728 15.8229 9.66433 15.6185 9.9048L11.863 14.6558C11.6554 14.9001 11.2876 14.9258 11.048 14.7128L8.47656 12.4271C8.24068 12.2174 8.21944 11.8563 8.42911 11.6204C8.63877 11.3845 8.99996 11.3633 9.23583 11.5729L11.3706 13.4705L14.8563 9.1903Z"" fill=""white"" />
                                        </svg>
                                    </span>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <ul class=""nav nav-stretch nav-line-tabs nav-line-tabs-2x border-transparent fs-5 fw-bold"">
                <ul class=""nav nav-stretch nav-line-t");
            WriteLiteral(@"abs nav-line-tabs-2x border-transparent fs-5 fw-bold"">
                    <li class=""nav-item mt-2"">
                        <a class=""nav-link text-active-primary ms-0 me-10 py-5 "" href=""/admin/Profile"">Overview</a>
                    </li>
                    <li class=""nav-item mt-2"">
                        <a class=""nav-link text-active-primary ms-0 me-10 py-5 active"" href=""/admin/EditProfile"">Settings</a>
                    </li>
                    <li class=""nav-item mt-2"">
                        <a class=""nav-link text-active-primary ms-0 me-10 py-5"" href=""/admin/SecurityProfile"">Security</a>
                    </li>
                </ul>
            </ul>
        </div>
    </div>
    <div class=""card mb-5 mb-xl-10"" id=""kt_profile_details_view"">
        <div class=""card-header cursor-pointer"">
            <div class=""card-title m-0"">
                <h3 class=""fw-bold m-0"">Profile Details</h3>
            </div>
        </div>
        <div class=""card-body p-9"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c692e714bc534a75b0cfb61bdb917d3da2fd1b012bed0c3cd3c481b8a55b8e018157", async() => {
                WriteLiteral("\n                <input type=\"hidden\" class=\"form-control form-control form-control-solid\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 8834, "\"", 8854, 1);
#nullable restore
#line 122 "C:\Users\landi\OneDrive\Робочий стіл\WebApplication\Views\Admin\EditProfile.cshtml"
WriteAttributeValue("", 8842, userInfo.Id, 8842, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                <div class=""row mb-7"">
                    <label class=""col-lg-4 fw-semibold text-muted"">Имя</label>
                    <div class=""col-lg-8"">
                        <input type=""text"" class=""form-control form-control form-control-solid"" name=""Name""");
                BeginWriteAttribute("value", " value=\"", 9127, "\"", 9149, 1);
#nullable restore
#line 126 "C:\Users\landi\OneDrive\Робочий стіл\WebApplication\Views\Admin\EditProfile.cshtml"
WriteAttributeValue("", 9135, userInfo.Name, 9135, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                    </div>
                </div>
                <div class=""row mb-7"">
                    <label class=""col-lg-4 fw-semibold text-muted"">Фамилия</label>
                    <div class=""col-lg-8"">
                        <input type=""text"" class=""form-control form-control form-control-solid"" name=""Surname""");
                BeginWriteAttribute("value", " value=\"", 9479, "\"", 9504, 1);
#nullable restore
#line 132 "C:\Users\landi\OneDrive\Робочий стіл\WebApplication\Views\Admin\EditProfile.cshtml"
WriteAttributeValue("", 9487, userInfo.Surname, 9487, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                    </div>
                </div>
                <div class=""row mb-7"">
                    <label class=""col-lg-4 fw-semibold text-muted"">Логин</label>
                    <div class=""col-lg-8"">
                        <input type=""text"" class=""form-control form-control form-control-solid"" name=""Login""");
                BeginWriteAttribute("value", " value=\"", 9830, "\"", 9858, 1);
#nullable restore
#line 138 "C:\Users\landi\OneDrive\Робочий стіл\WebApplication\Views\Admin\EditProfile.cshtml"
WriteAttributeValue("", 9838, userInfo.User.Login, 9838, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                    </div>
                </div>
                <div class=""row mb-7"">
                    <label class=""col-lg-4 fw-semibold text-muted"">Компания</label>
                    <div class=""col-lg-8 fv-row"">
                        <span class=""fw-semibold text-gray-800 fs-6""></span>
                        <input type=""text"" class=""form-control form-control form-control-solid"" name=""CompanyTitle""");
                BeginWriteAttribute("value", " value=\"", 10278, "\"", 10308, 1);
#nullable restore
#line 145 "C:\Users\landi\OneDrive\Робочий стіл\WebApplication\Views\Admin\EditProfile.cshtml"
WriteAttributeValue("", 10286, userInfo.CompanyTitle, 10286, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                    </div>
                </div>
                <div class=""row mb-7"">
                    <label class=""col-lg-4 fw-semibold text-muted"">Сайт компании</label>
                    <div class=""col-lg-8"">
                        <input type=""text"" class=""form-control form-control form-control-solid"" name=""CompanySite""");
                BeginWriteAttribute("value", " value=\"", 10648, "\"", 10677, 1);
#nullable restore
#line 151 "C:\Users\landi\OneDrive\Робочий стіл\WebApplication\Views\Admin\EditProfile.cshtml"
WriteAttributeValue("", 10656, userInfo.CompanySite, 10656, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                    </div>
                </div>
                <div class=""row mb-7"">
                    <label class=""col-lg-4 fw-semibold text-muted"">
                        Контактный номер телефона
                    </label>
                    <div class=""col-lg-8 d-flex align-items-center"">
                        <input type=""tel"" class=""form-control form-control form-control-solid"" name=""PhoneNumber""");
                BeginWriteAttribute("value", " value=\"", 11100, "\"", 11129, 1);
#nullable restore
#line 159 "C:\Users\landi\OneDrive\Робочий стіл\WebApplication\Views\Admin\EditProfile.cshtml"
WriteAttributeValue("", 11108, userInfo.PhoneNumber, 11108, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                    </div>
                </div>
                <div class=""row mb-7"">
                    <label class=""col-lg-4 fw-semibold text-muted"">
                        Country
                    </label>
                    <div class=""col-lg-8"">
                        <input type=""text"" class=""form-control form-control form-control-solid"" name=""Country""");
                BeginWriteAttribute("value", " value=\"", 11505, "\"", 11530, 1);
#nullable restore
#line 167 "C:\Users\landi\OneDrive\Робочий стіл\WebApplication\Views\Admin\EditProfile.cshtml"
WriteAttributeValue("", 11513, userInfo.Country, 11513, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                    </div>
                </div>
                <div class=""row mb-7"">
                    <label class=""col-lg-4 fw-semibold text-muted"">
                        Общая информация
                    </label>
                    <div class=""col-lg-8"">
                        <textarea type=""text"" class=""form-control form-control form-control-solid"" name=""Info"">");
#nullable restore
#line 175 "C:\Users\landi\OneDrive\Робочий стіл\WebApplication\Views\Admin\EditProfile.cshtml"
                                                                                                          Write(userInfo.Info);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</textarea>
                    </div>
                </div>
                <div class=""row mb-7"">
                    <label class=""col-lg-4 fw-semibold text-muted"">
                        Адресс
                    </label>
                    <div class=""col-lg-8"">
                        <input type=""text"" class=""form-control form-control form-control-solid"" name=""Address""");
                BeginWriteAttribute("value", " value=\"", 12312, "\"", 12337, 1);
#nullable restore
#line 183 "C:\Users\landi\OneDrive\Робочий стіл\WebApplication\Views\Admin\EditProfile.cshtml"
WriteAttributeValue("", 12320, userInfo.Address, 12320, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                    </div>
                </div>
                <div class=""row mb-7"">
                    <label class=""col-lg-4 fw-semibold text-muted"">
                        Занимаемая должность
                    </label>
                    <div class=""col-lg-8"">
                        <input type=""text"" class=""form-control form-control form-control-solid"" name=""JobTitle""");
                BeginWriteAttribute("value", " value=\"", 12727, "\"", 12753, 1);
#nullable restore
#line 191 "C:\Users\landi\OneDrive\Робочий стіл\WebApplication\Views\Admin\EditProfile.cshtml"
WriteAttributeValue("", 12735, userInfo.JobTitle, 12735, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                    </div>
                </div>
                <div class=""d-flex align-items-center justify-content-end"">
                    <input type=""reset"" class=""btn btn-danger me-3"" value=""Отмена"" />
                    <input type=""submit"" class=""btn btn-success"" value=""Обновить"" />
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n    </div>\n</div>\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

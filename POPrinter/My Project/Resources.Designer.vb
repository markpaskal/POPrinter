﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("POPrinter.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to                     GNU GENERAL PUBLIC LICENSE
        '''                       Version 3, 29 June 2007
        '''
        ''' Copyright (C) 2007 Free Software Foundation, Inc. &lt;http://fsf.org/&gt;
        ''' Everyone is permitted to copy and distribute verbatim copies
        ''' of this license document, but changing it is not allowed.
        '''
        '''                            Preamble
        '''
        '''  The GNU General Public License is a free, copyleft license for
        '''software and other kinds of works.
        '''
        '''  The licenses for most software and other practical works are designed
        '''to [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property COPYING() As String
            Get
                Return ResourceManager.GetString("COPYING", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to     Copyright 2015 Mark Paskal
        '''
        '''    This program is free software: you can redistribute it and/or modify
        '''    it under the terms of the GNU General Public License as published by
        '''    the Free Software Foundation, either version 3 of the License, or
        '''    (at your option) any later version.
        '''
        '''    This program is distributed in the hope that it will be useful,
        '''    but WITHOUT ANY WARRANTY; without even the implied warranty of
        '''    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
        '''    GNU General Public [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property License() As String
            Get
                Return ResourceManager.GetString("License", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Error, the path you supplied is no longer valid!.
        '''</summary>
        Friend ReadOnly Property OnLoadErrorText() As String
            Get
                Return ResourceManager.GetString("OnLoadErrorText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Welcome, please set a path and click &apos;Start&apos; to start printing files as they are saved..
        '''</summary>
        Friend ReadOnly Property WelcomeText1() As String
            Get
                Return ResourceManager.GetString("WelcomeText1", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to If you are seeing this and have already set up the path, your folder may have moved or changed names. Please click Browse to select the folder again..
        '''</summary>
        Friend ReadOnly Property WelcomeText2() As String
            Get
                Return ResourceManager.GetString("WelcomeText2", resourceCulture)
            End Get
        End Property
    End Module
End Namespace

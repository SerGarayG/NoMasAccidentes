   M S B A M L   `   `   `  ����L  HNoMasAccidentesv2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:NoMasAccidentesv2NoMasAccidentesv2  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   ,    &NoMasAccidentesv2.AsesoriaMasRealizada   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:NoMasAccidentesv2     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f6mah,http://metro.mahapps.com/winfx/xaml/controls  5   	     � Title$  AsesoriaMasRealizada��5
   	   $	��450��6&   $	��800��63   .��5      � 
�����w�.+�5   
   � -   5         �Name$ print��5      $
��Left=�6   $	��419��69   $	��Top=�6F   $	��792��6^   .+�5      �� $"��Imagenes/NoMasAccidentes.png��6   $��	44,28,0,0q�6:   $	��Top=�6M    J� RenderTransformOrigin$ 
0.465,0.36&�6e   $��34��6�    � Cursor$
 Hand��6�   {�.  $
��Left=�6�   $	��167��6�   �� 5      $&�� Tipo de asesoría más realizada��6   $
��Left=�6>   $��	55,82,0,0q�6Y   $	��Top=�6l   $��20(�6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ dgAsesoriaMasRealizada��5   3   
�����w�$
��Left=�6S   $
��auto��6n   $��
55,191,0,0q�6|   $	��Top=�6�   $
��auto��6�      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 200 6�      
IsReadOnly .  � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType	 �� Property
 �� Value��%�   '        �� 5      "  6   .�5      �� 	 � ��

 ���w�67   �� 5      	 � ��$
 0,0,1,2q�6<   �� 5      	 � ��

 �   �68   5      5      5      (  "System.Windows.Controls.DatePicker  5      -   5          Name$ dpInicio��5      $
��Left=�6+   $��106,149,0,0q�6F   $	��Top=�6[     5      -   5        $ 	dpTermino��5      $
��Left=�6,   $��319,149,0,0q�6G   $	��Top=�6\   �� 5      $��Desde:��6   $
��Left=�6%   $��
55,145,0,0q�6@   $	��Top=�6T   �� 5      $��Hasta:��6   $
��Left=�6%   $��272,145,0,0q�6@   $	��Top=�6U   �� 5      $"��Empresa: NoMásAccidentes  |��6   $��172,28,328,0q�6:   $	��Top=�6P   $��20(�6h   $ 0.891,0.703&�6v   �� 5      $��447,35,53,0q�6~   $	��Top=�6�   $��20(�6�   ��6   �� 
 �� Now �� Source# Z  �� StringFormat$* $Fecha de impresión:  {0:dd/MM/yyyy}��6�   5      � 5   
   .+�5       �� $��Profesional��6   $��	44,28,0,0q�6+   $	��Top=�6>   $��18(�6V   $ 
0.465,0.36&�6d   $��34��6�   
���   �
�����w�$
 Hand��6�   $��0,0,1,0q�6�   $��0,0,1,0q�6�   $
��Left=�6�   $	��167��6  �� 5!      $��Clientes��6   $
��Left=�6(   $��
211,28,0,0q�6C   $	��Top=�6W   $��18(�6o   $ 
0.465,0.36&�6}   $��34��6�   $	��167��6�   
���   �
�����w�$
 Hand��6�   $��1,0,1,0q�6�   �� 5"      $��	Contratos��6   $
��Left=�6)   $��
377,28,0,0q�6D   $	��Top=�6X   $��18(�6p   $ 
0.465,0.36&�6~   $��34��6�   $	��167��6�   
���   �
�����w�$
 Hand��6�   $��1,0,1,0q�6�   �� 5#      -   5         ��Name$ btnVentanaReportes��5#      $��Reportes��61   $
��Left=�6D   $��
544,28,0,0q�6_   $	��Top=�6s   $��18(�6�   $ 
0.465,0.36&�6�   $��34��6�   $	��189��6�   
���   �
�����w�$
 Hand��6  $��1,0,0,0q�6  6,  �� 5%      -   5        $ 
btnFiltrar��5%      $��Filtrar��6)   $
��Left=�6;   $��486,149,0,0q�6V   $	��Top=�6k   $��74��6�   6�   �� 5&      -   5        $��Imprimir��5&      $
��Left=�6(   $��
485,94,0,0q�6C   $	��Top=�6W   $��75��6o   6z   5(      5,      5-      
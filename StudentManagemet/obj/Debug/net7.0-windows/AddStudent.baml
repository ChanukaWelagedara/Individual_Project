   M S B A M L   `   `   `  ����K  GStudentManagemet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:StudentManagemetStudentManagemet  5   	   !    StudentManagemet.AddStudent   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:StudentManagemet     5   	     � Title$  
AddStudent��5   	   $	��720��6   $	��340��6)    � WindowStartupLocation$ CenterScreen=�5	   	    � AllowsTransparency$
 True��6.   
������  � WindowStyle$
 None=�5
   "   .��5      � .+�5   
   �� $��3q�6   
���   � �� Padding$ 20q�69   ���#243771._�5      �  � RowDefinitions 5      �� 5      $
��Auto �6$   �� 5      $��50 �6$   �� 5      $	��150 �6$   �� 5      $��* �6$   �� 5      $
��Auto �6$   .+�5      �� $��1��6   $��ADD STUDENT��6)      TextBoxText1#��[  6<   $	��150��6b   $��Bottom=�6n   $��Center=�6�   $��20(�6�   �� 5      $��2��6   $	��150��6G   $	��150��6S   ��6&   �� *SelectedImage+6S   �� 5#      $��3��6   ._�5$      � $��0,50,0,9q�6    � ColumnDefinitions 5%      �� 5&      $	��100 �6/   �� 5'      $	��13* �6/   �� 5(      $��2* �6/   �� 5)      $��* �6/    5+      �� 5,      $
��Auto �6,   �� 5-      $
��Auto �6,   �� 5.      $
��Auto �6,   �� 5/      $
��Auto �6,   �� 50      $
��Auto �6,   �� 51      $
��Auto �6,   �� 52      $
��Auto �6,   �� 53      $
��Auto �6,   �� 54      $
��Auto �6,   �� 55      $
��Auto �6,   .+�59      �� $��0��6$   $��	Firt Name��61     TextBoxText#��[ 6B   �� 5:        TextBoxBorder#��[ 6!   $��0��6H   $��1��6U   $��3��6e   ._�5;      ��   TextBoxStyle1#��[ 6f   ��6&   �� *	Firstname+ �� UpdateSourceTrigger$ PropertyChanged=�6f   5<      �� 5=      $��1��6$   $��	Last Name��61   #��[ 6B   �� 5>      #��[ 6!   $��1��6H   $��1��6U   $��3��6e   ._�5?      �� #��[ 6e   ��6&   �� *
Lastname+$ PropertyChanged=�6e   5@      �� 5A      $��2��6$   $	��Age��61   #��[ 6<   �� 5B      #��[ 6!   $��2��6H   $��1��6U   $��3��6e   ._�5C      �� #��[ 6`   ��6&   �� *Age+$ PropertyChanged=�6`   5D      �� 5E      $��3��6$   $��Date of Birth��61   #��[ 6F   �� 5F      #��[ 6!   $��3��6H   $��1��6U   $��3��6e   ._�5G      ��   TextBoxStyle#��[ 6C   ��6&   �� *Dateofbirth+6C   5I      �� 5K      $��4��6$   $	��GPA��61   #��[ 6<   �� 5L      #��[ 6!   $��4��6H   $��1��6U   $��3��6e   ._�5M      �� #��[ 6Y   ��6'   �� *Gpa+$ Default=�6Y   5N      �� 5O      $��5��6$   $��Gender��61   #��[ 6?   �� 5P      $��5��6%   $��1��62   $��3��6B    �� Orientation$ 
Horizontal=�6V   .+�5Q      	� $��Center=�6*   $
��Male��6E   	 d� 	IsChecked	 6T   �� *IsMale+
 �� Mode$
 TwoWay=�	� 5R      $��Center=�6*   $��Female��6E   	 6V   �� *
IsFemale+$
 TwoWay=�5T      �� 5V      $��6��6$   $��District��61   #��[ 6A   �� 5W      #��[ 6!   $��6��6H   $��1��6U   $��3��6e   ._�5X      �� #��[ 6f   ��6&   �� *	Livigtown+$ PropertyChanged=�6f   5Y      �� 5Z      $��7��6$   $
��Imge��61   #��[ 6=   �� 5[      $��	Add Image��6!   $
��Left=�66   $��7��6y   $��1��6�     
ButtonOne1#��[ 6�   $��3��6�   $��5,3,0,8q�6�   $	��100��6�   $��40��6�   ��6Q   �� *UploadPhotoCommand+6�   �� 5]      $��Add Student��6!   #��[ 6]   $��9��6�   $��4��6�   ��67   �� *AddStudentCommand+6�   �� 5_      $��Cancel��6!   #��[ 6T   $��9��6|   $��2��6�   $��47,60,11,-13q�6�   ��62   �� *CancelCommand+6�   5c      5d      5e      5f      5g      5i      
   M S B A M L   `   `   `  ����E  ADragablz, Version=0.0.3.203, Culture=neutral, PublicKeyToken=null5(clr-namespace:Dragablz;assembly=DragablzDragablz  5   	   P LDream_Society_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Dream_Society_ProjectDream_Society_Project 5   	   W0clr-namespace:Dream_Society_Project.UserControls"Dream_Society_Project.UserControls 5   	   &    Dream_Society_Project.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   =dragablz(clr-namespace:Dragablz;assembly=Dragablz     5   	   5local#clr-namespace:Dream_Society_Project     5   	   Bviews0clr-namespace:Dream_Society_Project.UserControls     5   	     � Title$  DreamSociety��5   	   $	��600��6   $	��720��6+    � WindowStyle$ 
ToolWindow=�67   .��5      � .+�5	   
   � $��50��6   $	��Top=�6   
����ح�.+�5
      �� $��Dream Project��6   
���   �$��Center=�6@   $��Center=�6]   $��20(�6x   $��Lucida Bright)�6�   5      � 5   
   $��0 45 0 0q�6   .+�5         Dragablz.TabablzControl     InterTabController 5      !   Dragablz.InterTabController  5      .@�5      �� $
��HOME��6   .��5      � 
����ح� � ColumnDefinitions 5      �� 5      $	��360 �6/   �� 5      $	��360 �6/    � RowDefinitions 5      �� 5!      $	��100 �6,   �� 5"      $	��100 �6,   �� 5#      $	��290 �6,   .+�5(      �� -   5         ��Name$ txtFileName��5(   &   $��35��6;   $	��280��6G   $��0��6S   $��Right=�6c   $��0,0,20,0q�6�   6�   �� 5)      -   5         ��Name$ 	btnBrowse��5)   %   $��1��68   $��Browse��6H      Circular#��[  6Y   $��45��6{   $��95��6�   $
��Left=�6�   $��10,0,0,0q�6�   
�����_�$��3q�6�   
����  �$��25(�6�   
����ح�6"  �� 5,      -   5        $ txtName��5,   "   $��Right=�63   $��35��6O   $��0,0,20,0q�6[   $��Center=�6m   $��1��6�   $��0��6�    �� TextWrapping$
 Wrap=�6�   $�� ��6�   $	��280��6�   �� 5.      -   5        $ 	btnSearch��5.   !   $��Search��64   $
��Left=�6E   $��1��6`   $��1��6p   $��Center=�6}   $��25(�6�   
����  �
�����_�$��3q�6�   
����ح�$��45��6�   $��95��6  #��[  6  $��10,0,0,0q�64  &   System.Windows.Controls.DataGrid  50      -   5          Name$ grdView��50   #   $��3��64   $��2��6H   $	��200��6U   $	��650��6b   ��6o   �� *lll+	   Columns	 51      0  *System.Windows.Controls.DataGridTextColumn  52   "   ,  &System.Windows.Controls.DataGridColumn
   Header$
 AadhaarNumber��6W   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *AadhaarNumber+6W     53   "   $

 Name��6N    65   �� *Name+6N     54   "   $
 Village��6Q    65   �� *	Village+6Q     55   "   $
 Mandal��6P    65   �� *Mandal+6P     56   "   $
 
BranchName��6T    65   �� *
BranchName+6T   4  .System.Windows.Controls.DataGridTemplateColumn  57   "   $

 Edit��69      CellTemplate 58   &   �� 59   *   .R�5:   .   �� $ btnEdit��65   -   5        $
��Edit��5:   F   6U   5;   +   5=   #   5?      5A      5C      �� 5E      -   5        $��create��5E      $��CREATE��6(   .��5F      3  -Dream_Society_Project.UserControls.UserDetail  5G      �� 5H      $��ABOUT��6   5I      5J      5K      5L      5M      
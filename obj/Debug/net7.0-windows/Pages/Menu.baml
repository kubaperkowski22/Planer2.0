   M S B A M L   `   `   `  ����E  APlaner 2.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Planer_2._0.PagesPlaner_2._0.Pages  5      )clr-namespace:Planer_2._0Planer_2._0  5          Planer_2._0.Pages.Menu   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:Planer_2._0.Pages     5      'nclr-namespace:Planer_2._0     5        N� Title$
  Menu��5
      .��5      � -   5         � ColumnDefinitions 5   
   �� 5      $	��267 �6   �� 5      $	��266 �6   �� 5      $	��267 �6    � RowDefinitions 5   
   �� 5      $	��120 �6   �� 5      $	��150 �6   �� 5      $	��180 �6   .+�5   
   �� $��0��6   $��1��5      $
��Menu��5      $��80(�5      $��Center=�5      $��Center=�5      $��SemiBold"�5         Planer_2._0.NavButton  5!   
   -   5          Name$ AddNewPlan_BT��5!      $��0��5"      $��1��5#         Text$ Dodaj nowy plan��5$      $	��170��5%      $��80��5&      $��Bottom=�5'      $��Right=�5(      $��20q�5)      $��Dodaj nowy plan��5*      ���	#FFDDDDDD$	��0.7q�5,      
���   �$��20(�5.         NavUri$ /Pages/NewPlan.xaml?�5/        52   
   -   5        $ EditPlan_BT��52      $��1��53      $��1��54      $	��170��55      $��80��56      $��Bottom=�57      $��Center=�58      $��20q�59      $ Edytuj plan��5:      ���	#FFDDDDDD$	��0.7q�5<      
���   �$��20(�5>        5A   
   -   5        $ BrowsePlans_BT��5A      $��2��5B      $��1��5C      $	��170��5D      $��80��5E      $��Bottom=�5F      $
��Left=�5G      $��20q�5H      $ Przeglądaj plany��5I      ���	#FFDDDDDD$	��0.7q�5K      
���   �$��20(�5M        5P   
   -   5        $ SavePlan_BT��5P      $��0��5Q      $��2��5R      $	��170��5S      $��80��5T      $	��Top=�5U      $��Right=�5V      $��20q�5W      $ Zapisz plan��5X      ���	#FFDDDDDD$	��0.7q�5Z      
���   �$��20(�5\        5_   
   -   5        $ OpenPlan_BT��5_      $��1��5`      $��2��5a      $	��170��5b      $��80��5c      $	��Top=�5d      $��Center=�5e      $��20q�5f      $ Otwórz plan��5g      ���	#FFDDDDDD$	��0.7q�5i      
���   �$��20(�5k        5n   
   -   5        $ Close_BT��5n         Planer_2._0.NavButton   Click$ Close_BT_Click��5{      $��2��5o      $��2��5p      $	��170��5q      $��80��5r      $	��Top=�5s      $
��Left=�5t      $��20q�5u      $ Zakończ��5v      $��20(�5w      ���	#FFDDDDDD$	��0.7q�5y      
���   �5{      5|      5�      
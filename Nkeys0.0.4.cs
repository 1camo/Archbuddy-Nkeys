using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using ArcheBuddy.Bot.Classes;

namespace FutureComboHotkeys{
public class FutureComboHotkeysclass : Core
{
  ////////////////////////////////////////////////////////
  //////// EDITABLES
  ////////////////////////////////////////////////////////    
  bool doLogs = true;               // Logging for debug purposes.   
  string [] combo1 = {"Боевой клич", "Вихрь смерти", "Удар щитом", "Подовление", "Очишение", "Решающий удар","Рывок", "Тройной удар", "Раскол земли", "Вихрь ударов", "Сокрушение разума", "Стресс", "Ужасающий крик", "Внушение усталости", "Сфера"};
  string [] combo2 = {"Хватка земли", "Молот олло"};
  string [] combo3 = {"Вихрь смерти", "Стресс", "Удар щитом", "Подовление", "Очишение"};
  ////////////////////////////////////////////////////////
  //////// Mainloop
  ////////////////////////////////////////////////////////  
   public void PluginRun()
   {
      ClearLogs();
      DebugLog("Script started"); 
      onKeyDown += keyDown;
      while (true)    
      {   
          Thread.Sleep(40);
      } 
   }
  ////////////////////////////////////////////////////////
  //////// Hotkeys event
  ////////////////////////////////////////////////////////        
  public void keyDown(Keys k, bool isControl, bool isShift, bool isAlt)
  {   
  if (/*isAlt && */k == Keys.D1)
    {
      UseSkills(combo1);
    }
  if (/*isAlt && */k == Keys.D2)
    {
      UseSkills(combo2);
    }
  if (/*isAlt && */k == Keys.D3)
    {
      UseSkills(combo3);
    }
  }        
  ////////////////////////////////////////////////////////
  //////// WaitUseSkill
  ////////////////////////////////////////////////////////         
  public void WaitUseSkill(string CurrentSkill)
  {
    DebugLog(": CurrentSkill ->" +CurrentSkill);    
    if (skillCooldown(CurrentSkill) == 0)
    {
      while (me.isCasting || me.isGlobalCooldown)
      {
          Thread.Sleep(40);
      }      
      UseSkill(CurrentSkill, false, false); 
      if (skillCooldown(CurrentSkill) > 0)
      {   
          DebugLog(": Used ->" +CurrentSkill); 
      }   
    }  
  }     
  ////////////////////////////////////////////////////////
  //////// UseSkills
  ////////////////////////////////////////////////////////         
  public void UseSkills(string[] skillNames)
  {
    DebugLog("--------------- Combo started ---------------");
    foreach (string skl in skillNames)
    { 
        WaitUseSkill(skl); 
    }            
  }
  ////////////////////////////////////////////////////////
  //////// Debug
  ////////////////////////////////////////////////////////  
  public void DebugLog(string Logger_string)
  {
    if (doLogs == true)
    {  
      Log(Time() + Logger_string);   
    }  
  } 
  ////////////////////////////////////////////////////////
  //////// GetTime
  ////////////////////////////////////////////////////////          
  public string Time() //- Get Time
  {
    string A = DateTime.Now.ToString("[hh:mm:ss] ");
    return A;
  }              
  ////////////////////////////////////////////////////////
  //////// Stop
  ////////////////////////////////////////////////////////            
   public void PluginStop()
   {  
    onKeyDown -= keyDown;   
    DebugLog("Script stoped"); 
   }    
  ////////////////////////////////////////////////////////
  //////// INFO
  ////////////////////////////////////////////////////////          
   public static string GetPluginAuthor()
   { 
    return "CAMOTbIK";
   }
   public static string GetPluginVersion()
   { 
    return "0.0.0.4 ALPHA"; 
   }
   public static string GetPluginDescription()
   {
    return "Nkeys"; 
   }  
}}
   
  

function Division($number1,$number2)
{
    
    $result=$number1/$number2
    trap [System.DivideByZeroException]
     {
        Write-Host "Divde by zero is not possible"
        break;
     }
    $result
}
function input
{
    $data=Read-Host "Please Enter Number"
    return $data
}
try
{
    cls
    [Int]$num1= input
    if($num1 -isnot [int])
    {
      throw [System.Management.Automation.RuntimeException]
    }
    
    [Int]$num2= input
   
    
    if($num1 -isnot [int32])
    {
      throw [System.Management.Automation.RuntimeException]
    }
Division $num1 $num2
}
catch [System.Management.Automation.RuntimeException]
{
  
    Write-Host "Please give valid input"
    $result=$null
    
}
catch
{
    Write-Host $_.Exception.Message
}


int distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int count = 0;
int time = 0;
int friend = 2;

while (distance > 10)
{
  if (friend == 1)// Была ошибка не поставил"=="
  {
    time = distance / (firstFriendSpeed + dogSpeed);
    friend = 2;
  }
  else
  {
    time = distance / (secondFriendSpeed + dogSpeed);
    friend = 1;
  }
  distance = (firstFriendSpeed + secondFriendSpeed) * time;

  count++;
}

Console.Write("count = ");
Console.WriteLine(count);

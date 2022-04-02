using System;

namespace CSLight_2._12
{
    class Program
    {
        static void Main(string[] args)
        {
            string shadowMageName = "Маг";
            char shadowMage = 'A';
            int shadowMagePositionX1 = 25;
            int shadowMagePositionX2 = shadowMagePositionX1 - 1;
            int shadowMagePositionY = 15;
            int shadowMageNamePositionX = shadowMagePositionX1 - 1;
            int shadowMageNamePositionY = shadowMagePositionY - 1;

            int shadowMageMP = 1000;
            int shadowMageHP = 1000;
            int shadowMageMPPositionX = 2;
            int shadowMageMPPositionY = shadowMageNamePositionY - 5;
            int shadowMageHPPositionX = 2;
            int shadowMageHPPositionY = shadowMageNamePositionY - 6;

            string enemyBossName = "БОСС";
            string enemyBoss = "\\_(u J u)\\_";
            int enemyBossPositionX = 75;
            int enemyBossPositionY = shadowMagePositionY;
            int enemyBossNamePositionX = enemyBossPositionX + 3;
            int enemyBossNamePositionY = shadowMageNamePositionY;

            int enemyBossHP = 1000;
            int minEnemyBossDamageDeal = 0;
            int maxEnemyBossDamageDeal = 201;
            int enemyBossHPPositionX = 90;
            int enemyBossHPPositionY = shadowMageNamePositionY - 6;

            int spell1PriceMP = 200;
            int spell2PriceMP = 50;
            int spell2DamageDeal = 130;
            int spell3PriceHP = 100;
            int spell3DamageDeal = 100;
            int spell4HealedHP = 300;

            string shadowSpirit1 = "/";
            string shadowSpirit2 = "_";
            bool isShadowSpiritHere = false;
            int shadowSpiritPositionX1 = shadowMagePositionX1 - 1;
            int shadowSpiritPositionX2 = shadowSpiritPositionX1 - 1;
            int shadowSpiritPositionY = shadowMagePositionY;

            string shadowMageWithCrimsonWings = "^A^";
            bool isCrimsonWingsHere = false;
            bool isCrimsonWingsCocoonHere = false;

            bool isAlive = true;
            int enoughHP = 0;
            int spellCast;

            int frame1TextPositionX = 13;
            int frame1Text1PositionY = 10;
            int frame1Text2PositionY = 11;
            int frame1Text3PositionX = 63;
            int frame1Text3PositionY = 20;

            int frame2MenuPositionX = 0;
            int frame2MenuPositionY = 21;

            int frame2SpellText1PositionY = 11;
            int frame2SpellText2PositionY = 12;

            int frame2SpellText1PositionX = 35;
            int frame2Spell1Text2PositionX = 16;
            int frame2Spell1Text3PositionX = 10;
            int frame2Spell2Text1PositionX = 50;
            int frame2Spell3TextPositionX = 33;
            int frame2Spell4Text1PositionX = 20;
            int frame2Spell4Text2PositionX = 37;
            int frame2Spell4Text3PositionX = 28;
            int frame2DefaultPositionX = 47;

            int frame2HeaderPositionX = 50;
            int frame2HeaderPositionY = 3;

            int frame3TextPositionX = 13;
            int frame3TextPositionY = 20;

            int frame2EnemyBossAttackPositionX = 50;
            int frame2EnemyBossAttackPositionY = 10;
            int frame2CrimsonWingsCocoonProtectionPositionX = 48;
            int frame2CrimsonWingsCocoonProtectionPositionY = 10;

            Random random = new Random();
            int enemyBossDamageDeal;

            Console.SetCursorPosition(frame1TextPositionX, frame1Text1PositionY);
            Console.Write("Вы – Теневой маг, и у Вас в арсенале есть четыре заклинания, которые вы можете использовать.");
            Console.SetCursorPosition(frame1TextPositionX, frame1Text2PositionY);
            Console.Write("Вы должны уничтожить БОССА, и только после этого Вы обретете покой.");
            Console.SetCursorPosition(frame1Text3PositionX, frame1Text3PositionY);
            Console.Write("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
            Console.Clear();

            while (isAlive)
            {
                Console.SetCursorPosition(frame2HeaderPositionX, frame2HeaderPositionY);
                Console.WriteLine("БИТВА С БОССОМ");

                Console.SetCursorPosition(shadowMageHPPositionX, shadowMageHPPositionY);
                Console.Write("HP: " + shadowMageHP);
                Console.SetCursorPosition(shadowMageMPPositionX, shadowMageMPPositionY);
                Console.Write("MP: " + shadowMageMP);
                Console.SetCursorPosition(shadowMageNamePositionX, shadowMageNamePositionY);
                Console.Write(shadowMageName);

                if (isCrimsonWingsHere == false)
                {
                    Console.SetCursorPosition(shadowMagePositionX1, shadowMagePositionY);
                    Console.Write(shadowMage);
                }
                else
                {
                    Console.SetCursorPosition(shadowMagePositionX2, shadowMagePositionY);
                    Console.Write(shadowMageWithCrimsonWings);
                }

                if (isShadowSpiritHere == true)
                {
                    if (isCrimsonWingsHere == false)
                    {
                        Console.SetCursorPosition(shadowSpiritPositionX1, shadowSpiritPositionY);
                        Console.WriteLine(shadowSpirit1);
                    }
                    else
                    {
                        Console.SetCursorPosition(shadowSpiritPositionX2, shadowSpiritPositionY);
                        Console.WriteLine(shadowSpirit2);
                    }
                }

                Console.SetCursorPosition(enemyBossHPPositionX, enemyBossHPPositionY);
                Console.Write("HP: " + enemyBossHP);
                Console.SetCursorPosition(enemyBossNamePositionX, enemyBossNamePositionY);
                Console.Write(enemyBossName);
                Console.SetCursorPosition(enemyBossPositionX, enemyBossPositionY);
                Console.Write(enemyBoss);

                Console.SetCursorPosition(frame2MenuPositionX, frame2MenuPositionY);
                Console.WriteLine(" Выберите заклинание: " +
                    "\n1: Призывает подконтрольного Теневого духа. Цена: -" + spell1PriceMP + " MP." +
                    "\n2: Теневой дух наносит врагу " + spell2DamageDeal + " ед. урона. Цена: -" + spell2PriceMP +" MP." +
                    "\n3: За Вашей спиной появляются Багровые крылья. Они поджигают врага и наносят " + spell3DamageDeal + " ед. урона. Цена: -" + spell3PriceHP + " HP." +
                    "\n4: Позволяет на один ход скрыться в кокон за Багровыми крыльями и восстановить " + spell4HealedHP + " HP. Урон врага по Вам не проходит.\nПотом крылья сгорают.\n");
                spellCast = Convert.ToInt32(Console.ReadLine());

                switch (spellCast)
                {
                    case 1:
                        if (isShadowSpiritHere == true)
                        {
                            Console.SetCursorPosition(frame2SpellText1PositionX, frame2SpellText1PositionY);
                            Console.Write("Голоса в голове звучат громче, чем обычно.");
                            Console.SetCursorPosition(frame2Spell1Text2PositionX, frame2SpellText2PositionY);
                            Console.Write("В бреду Вы читаете заклинание, вызывающее Теневого духа. Но ведь он уже рядом.");
                        }
                        else
                        {
                            Console.SetCursorPosition(frame2Spell1Text3PositionX, frame2SpellText2PositionY);
                            Console.Write("Рядом с Вами, словно из-под земли, дымом поднимается темная фигура. Её очертания похожи на Вас.");
                            isShadowSpiritHere = true;
                            shadowMageMP -= spell1PriceMP;
                        }
                        break;
                    case 2:
                        if (isShadowSpiritHere == true)
                        {
                            shadowMageMP -= spell2PriceMP;
                            enemyBossHP -= spell2DamageDeal;
                            Console.SetCursorPosition(frame2Spell2Text1PositionX, frame2SpellText2PositionY);
                            Console.Write("-" + spell2DamageDeal + " HP =>");
                        }
                        else
                        {
                            Console.SetCursorPosition(frame2SpellText1PositionX, frame2SpellText2PositionY);
                            Console.Write("Вы отдаете приказ, но его некому исполнять.");
                        }
                        break;
                    case 3:
                        if (isCrimsonWingsHere == true)
                        {
                            Console.SetCursorPosition(frame2Spell3TextPositionX, frame2SpellText1PositionY);
                            Console.Write("Нервы сжаты жгутом, и серое вещество кипит лавой.");
                            Console.SetCursorPosition(frame2Spell3TextPositionX, frame2SpellText2PositionY);
                            Console.Write("Вы бормочете заклинание, но ничего не происходит.");
                        }
                        else
                        {
                            Console.SetCursorPosition(frame2Spell1Text3PositionX, frame2SpellText2PositionY);
                            Console.Write("Лопатки пронзает резкая боль. Огромной тенью нависнут над головой тлеющие Багровые крылья.");
                            isCrimsonWingsHere = true;
                            shadowMageHP -= spell3PriceHP;
                        }
                        break;
                    case 4:
                        if (isCrimsonWingsHere == true)
                        {
                            Console.SetCursorPosition(frame2Spell4Text1PositionX, frame2SpellText1PositionY);
                            Console.Write("Вы кутаетесь в кокон из огромных горячих Крыльев, закрываясь от вражеских атак.");
                            Console.SetCursorPosition(frame2Spell4Text2PositionX, frame2SpellText2PositionY);
                            Console.Write("Вы чувствуете, как становится легче дышать.");
                            shadowMageHP += spell4HealedHP;
                            isCrimsonWingsCocoonHere = true;

                        }
                        else
                        {
                            Console.SetCursorPosition(frame2Spell4Text3PositionX, frame2SpellText2PositionY);
                            Console.Write("Вы чувствуете холод и сожаление. Вам негде спрятаться.");
                        }
                        break;
                    default:
                        Console.SetCursorPosition(frame2DefaultPositionX, frame2SpellText2PositionY);
                        Console.Write("Бред, бред, бред.");
                        break;
                }

                Console.ReadKey();

                if (isCrimsonWingsCocoonHere == false)
                {
                    enemyBossDamageDeal = random.Next(minEnemyBossDamageDeal, maxEnemyBossDamageDeal);
                    shadowMageHP -= enemyBossDamageDeal;
                    Console.SetCursorPosition(frame2EnemyBossAttackPositionX, frame2EnemyBossAttackPositionY);
                    Console.Write("<= -" + enemyBossDamageDeal + " HP");
                }
                else
                {
                    Console.SetCursorPosition(frame2CrimsonWingsCocoonProtectionPositionX, frame2CrimsonWingsCocoonProtectionPositionY);
                    Console.Write("Вы в безопасности.");
                    isCrimsonWingsCocoonHere = false;
                    isCrimsonWingsHere = false;
                }

                if (shadowMageHP <= enoughHP || enemyBossHP <= enoughHP)
                {
                    isAlive = false;
                }

                Console.ReadKey();
                Console.Clear();
            }

            if (shadowMageHP <= enoughHP && enemyBossHP <= enoughHP)
            {
                Console.SetCursorPosition(frame3TextPositionX, frame3TextPositionY);
                Console.Write("Никого больше нет.");
                Console.ReadKey();
            }
            else if (shadowMageHP <= enoughHP)
            {
                Console.SetCursorPosition(frame3TextPositionX, frame3TextPositionY);
                Console.Write("Маг пал.");
                Console.ReadKey();
            }
            else
            {
                Console.SetCursorPosition(frame3TextPositionX, frame3TextPositionY);
                Console.Write("БОСС повержен. Но вы не чувствуете облегчения...");
                Console.ReadKey();
            }
        }
    }
}

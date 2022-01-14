﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace WDPR_A.Migrations
{
    [DbContext(typeof(WDPRContext))]
    [Migration("20220114092653_1")]
    partial class _1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("ChatClient", b =>
                {
                    b.Property<string>("ChatsCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClientsId")
                        .HasColumnType("TEXT");

                    b.HasKey("ChatsCode", "ClientsId");

                    b.HasIndex("ClientsId");

                    b.ToTable("ChatClient");
                });

            modelBuilder.Entity("ClientGuardian", b =>
                {
                    b.Property<string>("ClientsId")
                        .HasColumnType("TEXT");

                    b.Property<string>("GuardiansId")
                        .HasColumnType("TEXT");

                    b.HasKey("ClientsId", "GuardiansId");

                    b.HasIndex("GuardiansId");

                    b.ToTable("ClientGuardian");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("WDPR_A.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("IncomingClientId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("OrthopedagogueId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("IncomingClientId");

                    b.HasIndex("OrthopedagogueId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("WDPR_A.Models.Chat", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("TEXT");

                    b.Property<string>("OrthopedagogueId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Code");

                    b.HasIndex("OrthopedagogueId");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("WDPR_A.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ChatCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("When")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ChatCode");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("WDPR_A.Models.User", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("User");
                });

            modelBuilder.Entity("WDPR_A.Models.Client", b =>
                {
                    b.HasBaseType("WDPR_A.Models.User");

                    b.Property<int>("AgeCategory")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ChatCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("Condition")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("Client");
                });

            modelBuilder.Entity("WDPR_A.Models.Guardian", b =>
                {
                    b.HasBaseType("WDPR_A.Models.User");

                    b.Property<int?>("AppointmentId")
                        .HasColumnType("INTEGER");

                    b.HasIndex("AppointmentId");

                    b.HasDiscriminator().HasValue("Guardian");
                });

            modelBuilder.Entity("WDPR_A.Models.Orthopedagogue", b =>
                {
                    b.HasBaseType("WDPR_A.Models.User");

                    b.Property<string>("OrthopedagogueWebText")
                        .HasColumnType("TEXT");

                    b.Property<string>("PictureUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Specialty")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("Orthopedagogue");

                    b.HasData(
                        new
                        {
                            Id = "d82d98fb-1e39-4dc8-be32-ef25e3756c9c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "de3c50d5-0cfc-43f3-bde0-a1daf2cd5ca5",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "56b6735e-2eb4-41f1-952f-a7e323ecf4f0",
                            TwoFactorEnabled = false,
                            FirstName = "Karin",
                            LastName = "Kemper",
                            OrthopedagogueWebText = "<h1>Karin Kemper</h1> <br><br>\r\n\r\n<article>\r\n    <h2>Even voorstellen</h2>\r\n    <section>Ik heet Karin Kemper, geboren in 1972 in Almere en ben het enige kind.  Mijn vader is Argentijns en mijn moeder is Nederlands. Ik ben heel nieuwsgierig naar mensen met ADHD; naar wat hun motiveert, wat hun concentratievermogen is en hoe ik ze persoonlijk kan helpen. Toen ik jong was begon ik al met hulp aanbieden bij kinderen met ADHD. </section>\r\n    <br><br>\r\n\r\n\r\n\r\n     <h2>Mijn studie   </h2>\r\n     <section>Na het behalen van mijn gymnasium ging ik werken in de Albert Heijn om geld te verdienen voor mijn opleiding. Hierna had ik orthopedagogiek gestudeerd aan de Universiteit van Leiden. Tijdens mijn studie heb ik mij gespecialiseerd in de behandeling van ADHD en had een bijbaantje als bezorger. </section>\r\n     <br><br>\r\n\r\n     <h2>Nu over jou: jij hebt misschien ADHD </h2>\r\n     <section>Bij jou bestaat het vermoeden dat je ADHD hebt. Als je ADHD hebt, heb je moeite om je aandacht bij iets te houden en dat je te druk bent. Bij ADHD word je afgeleid bij alle prikkels die bij jou binnenkomen en dat je je dan ook druk gedraagt. De gevolgen hiervan zijn dat je de informatie niet goed onthoudt en je misschien andere mensen lastigvalt zonder dat je, het door hebt. \r\n    </section>\r\n    <br><br>\r\n\r\n\r\n    <h2>Wat gaan we doen?  </h2>\r\n    <section>Ik ga met jou uitzoeken of jij ADHD hebt met een paar gesprekken waarbij evt. ook jouw ouder(s)/verzorger(s) betrokken worden. Mocht het blijken dat je ADHD hebt kijken we samen naar de problemen die je ervaart en hoe we dat stap voor stap kunnen oplossen.  Ik ga mijn uiterst best doen om je te helpen concentreren en je te kalmeren.  \r\n\r\n        Allereerst luister ik graag actief naar je. Dit betekent dat ik tijdens het luisteren ook vragen ga stellen. Dit is om meer inzicht te krijgen in hoe ik jou kan helpen.  \r\n        \r\n        Wil je eerst nog meer informatie; bel, app of mail me gerust. We plannen in ieder geval een intakegesprek om elkaar beter te leren kennen. Daarna kun je je evt.-in overleg met je ouder(s)/verzorger(s)-inschrijven voor een behandeling. </section>\r\n        <br><br>\r\n\r\n\r\n    <h2>Hoe meld ik mij aan? </h2>\r\n    <section>Je kan op onze website aanmelden via de registratie knop op de hoofdpagina. Bij de registratie moet je aan een aantal voorwaarden voldoen om een intakegesprek te plannen. Na het intakegesprek ben je succesvol aangemeld. \r\n    </section>\r\n    <br><br>\r\n\r\n\r\n    <h2>Hoe kan ik chatten met mijn hulpverlener? \r\n    </h2>\r\n    <section>Na de login, verschijnt er een chat-icoon die jou de mogelijkheid biedt om met hulpverlener privé te chatten. Of je kan mij altijd mailen naar karinkemper@ZMDH.nl \r\n    </section>\r\n    <br><br>\r\n\r\n\r\n    <h2>Hoe kan ik deelnemen aan de groepschat? </h2>\r\n    <section>Na de login verschijnt er een chat-icoon die jou de mogelijkheid biedt om deel te nemen aan een groepschat. </section>\r\n</article>  <br><br>\r\n",
                            PictureUrl = "https://i.postimg.cc/tRPnMpWP/Karin-Kemper-Orthopedagoog.png",
                            Specialty = "ADHD"
                        },
                        new
                        {
                            Id = "c43c63bc-5901-447e-8137-aa37834e42f7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "156b79ee-c147-4c44-ac44-557486dc8c91",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "faedcfea-e105-4150-bf0b-9faac154ad07",
                            TwoFactorEnabled = false,
                            FirstName = "Johan",
                            LastName = "Lo",
                            OrthopedagogueWebText = "<h1>Johan Lo</h1> <br> <br>\r\n\r\n<article>\r\n    <h2>Even voorstellen </h2>\r\n    <section>Ik heet Johan Lo, geboren in 1990 in Rotterdam en de jongste van zes kinderen. Ik ben opgegroeid bij de haven door mijn ouders. Ik verdiep me in de laatste trends van jongeren en vind het interessant hoe de huidige generatie van jongeren zicht inzet voor belangrijke maatschappelijke problemen, zoals klimaatverandering. Jongs af aan probeerde ik jongeren te motiveren om dingen te doen waar ze bang voor zijn.  \r\n    </section> <br> <br>\r\n\r\n    <h2>Mijn studie   \r\n    </h2>\r\n    <section>Na het VWO begon ik met stand up comedy en werkte ik twee jaar lang als een motiverende spreker bij verschillende bedrijven en evenementen. Hierna had ik orthopedagogiek gestudeerd aan de Universiteit van Cambridge. Tijdens mijn studie heb ik mij gespecialiseerd in de behandeling van faalangst.  \r\n    </section> <br> <br>\r\n\r\n    <h2>Nu over jou: jij hebt misschien faalangst   \r\n    </h2>\r\n    <section>Bij jou bestaat het vermoeden dat je faalangst hebt. Veelal gaat dit over het uitvoeren van iets concreets zoals een taak, een examen, een werkopdracht en dergelijke. De gevolgen hiervan is dat je vaker faalervaring ervaart.  \r\n    </section> <br> <br>\r\n\r\n    <h2>Wat gaan we doen?   \r\n    </h2>\r\n    <section>Ik ga met jou uitzoeken of jij faalangst hebt met een paar gesprekken waarbij evt. ook jouw ouder(s)/verzorger(s) betrokken worden. Mocht het blijken dat je faalangst hebt kijken we samen naar de problemen die je ervaart en hoe we dat stap voor stap kunnen oplossen. Met therapie kan ik je helpen om sterker te staan in je schoenen en een positiever beeld te creëren over jezelf. \r\n        Allereerst luister ik graag aandachtig naar je. Ik ben namelijk een actieve luisteraar en beantwoord graag vragen die je hebt. Daarna ga ik een gesprek met je aan om te kijken waarom je faalangst ervaart. We gaan ook je faalangst confronteren met positieve denkpatronen. Wil je eerst nog meer informatie; bel, app of mail me gerust. We plannen in ieder geval een intakegesprek om elkaar beter te leren kennen. Daarna kun je je evt.-in overleg met je ouder(s)/verzorger(s)-inschrijven voor een behandeling. \r\n        </section> <br> <br>\r\n\r\n    <h2>Hoe meld ik mij aan? </h2>\r\n    <section>Je kan op onze website aanmelden via de registratie knop op de hoofdpagina. Bij de registratie moet je aan een aantal voorwaarden voldoen om een intakegesprek te plannen. Na de intakegesprek ben je succesvol aangemeld. \r\n    </section> <br> <br>\r\n\r\n    <h2>Hoe kan ik chatten met mijn hulpverlener? </h2>\r\n    <section>Na de login, verschijnt er een chat-icoon die jou de mogelijkheid biedt om met hulpverlener privé te chatten. Of je kan mij altijd mailen naar johanlo@ZMDH.nl \r\n    </section> <br> <br>\r\n\r\n    <h2>Hoe kan ik deelnemen aan de groepschat? </h2>\r\n    <section>Na de login verschijnt er een chat-icoon die jou de mogelijkheid biedt om deel te nemen aan een groepschat. </section> <br> <br>\r\n\r\n</article><br><br>\r\n\r\n\r\n",
                            PictureUrl = "https://i.postimg.cc/9fwqH7rm/Johan-Lo-Orthopedagoog.png",
                            Specialty = "Faalangst"
                        },
                        new
                        {
                            Id = "68eb79de-06bb-4f45-970c-2d7755931f0c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "78f3b1cb-a7fb-49bf-9214-43fb87874735",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ce6aa1ae-52a3-4bd6-8dba-826b4d92f1ee",
                            TwoFactorEnabled = false,
                            FirstName = "Steven",
                            LastName = "Ito",
                            OrthopedagogueWebText = "<h1>Steven Ito</h1> <br> <br>\r\n\r\n<article>\r\n    <h2>Even voorstellen   </h2>\r\n    <section> Mijn naam is Steven Ito, ik ben geboren in 1987 in het hartje van Amsterdam. Mijn ouders hadden allebei een medische achtergrond en komen oorspronkelijk uit Japan. Ik heb al sinds mijn jeugd een passie gehad voor de medische wereld en het helpen van mensen, specifiek de jongeren. Omdat het mij interesseert hoe jongeren hun leven leiden. \r\n    </section> <br> <br>\r\n\r\n    <h2>Mijn studie   </h2>\r\n    <section> Na het VWO heb ik orthopedagogiek gestudeerd aan de Universiteit van Amsterdam. Bij mijn afstuderen heb ik mij gespecialiseerd in de behandeling van eetstoornissen. Daarna heb ik nog een tweejarig masterprogramma gevolgd in het buitenland op de Medische Universiteit van Tokyo. \r\n    </section> <br> <br>\r\n\r\n    <h2>Nu over jou: jij hebt misschien een eetstoornis  \r\n    </h2>\r\n    <section> Bij jou bestaat het vermoeden dat je een eetstoornis hebt. Soms wordt gedacht dat er maar één eetstoornis is. Maar dit klopt niet, want er zijn verschillende soorten zoals: boulimia, anorexia en Binge Eating Disorder (BED). Sommige eetstoornissen zijn niet altijd zichtbaar en worden daarom ook ‘onzichtbare eetstoornissen’ genoemd. Als het goed is merk je dat je een verstoord en onregelmatig eetgedrag hebt. Dit wordt gekenmerkt dat er soms te weinig wordt gegeten en in andere perioden juist te veel wordt gegeten. Het heeft voornamelijk te maken met een verstoord lichaamsbeeld. Misschien heb je gemerkt dat je een angst hebt om dik te worden of juist om dun te worden, toch? Verder zijn er lichamelijke klachten zoals misselijkheid of maagpijn. Daarnaast herken je misschien dat je liever niet wilt eten als andere mensen in de buurt zijn. \r\n    </section> <br> <br>\r\n\r\n    <h2>Wat gaan we doen?  </h2>\r\n    <section>Ik ga met jou samen onderzoeken of jij een eetstoornis hebt met een paar testen, waarbij eventueel jouw ouder(s)/verzorger(s) betrokken worden. Mocht blijken uit de resultaten dat je toch een eetstoornis hebt. Dan zullen we samen bekijken waar jij moeite mee hebt of tegen aanloopt. We zullen dan samen stap-voor-stap ervoor zorgen dat we jouw eetstoornis en verstoord lichaamsbeeld verhelpen. \r\n\r\n        Daarna gaan we met elkaar aan de slag en probeer ik je verder te helpen met tips en oefeningen, die laagdrempelig zijn, wat vooral prettig is voor jou.   \r\n         Er zal in het proces veel humor en gezelligheid zijn. We gaan niet te ingewikkeld doen, maar onze mouwen opstropen en aan het werk met jouw grootste uitdagingen is de missie waaraan wij gaan werken.   \r\n        \r\n        Je bent van harte welkom. Ik help je heel graag. Wil je eerst nog meer informatie; bel of mail me gerust. We plannen in ieder geval een intakegesprek in om te zien of wij graag met elkaar verder willen. Daarna kun je je eventueel in overleg met je ouder(s)/verzorger(s)-inschrijven voor een behandeling. \r\n        </section> <br> <br>\r\n\r\n    <h2>Hoe meld ik mij aan? </h2>\r\n    <section>Je kan op onze website aanmelden via de registratie knop op de hoofdpagina. Bij de registratie moet je aan een aantal voorwaarden voldoen om een intakegesprek te plannen. Na de intakegesprek ben je succesvol aangemeld. \r\n    </section> <br> <br>\r\n\r\n    <h2>Hoe kan ik chatten met mijn hulpverlener? \r\n    </h2>\r\n    <section>Na de login, verschijnt er een chat-icoon die jou de mogelijkheid biedt om met hulpverlener privé te chatten. Of je kan mij altijd mailen naar stevenito@ZMDH.nl \r\n    </section> <br> <br>\r\n\r\n    <h2>Hoe kan ik deelnemen aan de groepschat? </h2>\r\n    <section>Na de login verschijnt er een chat-icoon die jou de mogelijkheid biedt om deel te nemen aan een groepschat. </section> <br> <br>\r\n\r\n</article> <br><br>\r\n",
                            PictureUrl = "https://i.postimg.cc/bNbyP9RF/Steven-Ito-Orthopedagoog.png",
                            Specialty = "Eetstoornis"
                        },
                        new
                        {
                            Id = "deb0b863-d5b7-4534-b6cd-3ab28a7d629a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c4c67c5b-ad99-498d-8b46-27646e00f83c",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6f000543-d612-4bda-a725-a9f6694f949c",
                            TwoFactorEnabled = false,
                            FirstName = "Marianne",
                            LastName = "van Dijk",
                            OrthopedagogueWebText = "<h1>Marianne Van Dijk</h1> <br> <br>\r\n\r\n<article>\r\n    <h2>Even voorstellen \r\n    </h2>\r\n    <section>Hallo, ik ben Marianne van Dijk geboren en getogen in Rotterdam. Vanaf kleins af aan vind ik het altijd leuk om kinderen te helpen, ik haal hier namelijk mijn voldoening uit. Verder ben ik een moeder van drie kinderen, waarvan er een dyslexie heeft. Zelf heb ik ook dyslexie. Misschien valt het je op dat dyslexie een onderwerp is wat regelmatig in mijn leven ter sprake komt, hierdoor wil ik graag mijn ervaring delen met kinderen die hulp willen. \r\n    </section> <br> <br>\r\n\r\n    <h2>Mijn studie \r\n    </h2>\r\n    <section>Omdat ik moeite had met lezen liep ik veel achterstand. Ik ben vanaf VMBO Basis begonnen en door de jaren heen ben ik verder gaan studeren. Uiteindelijk heb ik de opleiding orthopedagogiek afgerond aan de Universiteit van Leiden. \r\n    </section> <br> <br>\r\n\r\n    <h2>Nu over jou: Jij hebt misschien dyslexie </h2>\r\n    <section>Dyslexie hebben is niet prettig. Het maakt lezen, spellen en schrijven veel ingewikkelder, terwijl iemand wel intelligent genoeg is om dat allemaal te begrijpen. Er is pas sprake van dyslexie als er geen andere oorzaken zijn die de leesproblemen kunnen verklaren. \r\n        Niet elke kind dat dyslexie heeft, heeft moeite met spelling en lezen. Sommige kinderen hebben vooral problemen met het lezen en anderen met spelling. Zo heb je bijvoorbeeld kinderen die radend lezen, waardoor ze veel fouten maken doordat ze gokken wat er staat. Anderen lezen letter voor letter, waardoor het leestempo heel laag ligt. \r\n        \r\n    </section> <br> <br>\r\n\r\n    <h2>Wat gaan we doen? </h2>\r\n    <section>Samen gaan we uitzoeken of jij dyslexie hebt. Dat doen we door verschillende soorten testen uit te voeren. Bij het uitvoeren van de testen merk ik vanzelf of jij symptomen hebt. Het zijn testen, zoals het hardop lezen van teksten of het uitspreken van klanken en letters. \r\n\r\n        Wat we vooral merken is dat je moeite hebt met het verschil te horen tussen klanken als: ‘m’, ‘n’, en ‘ng’, of ‘eu’, ‘uu’ en ‘ui’. Of je hebt moeite om op woorden te komen. En zo zijn er nog andere symptomen. \r\n        \r\n        Je bent van harte welkom en ik wil je graag bij helpen om mee om te gaan. Je kan mij altijd gerust bereiken voor meer informatie of uitleg door mij te bellen of te mailen. We maken eerst een intakegesprek zodat wij zien of we met elkaar verder willen. En uiteraard kun je je eventueel in overleg met je ouder(s)/verzorg(s) inschrijven voor een behandeling. \r\n        </section> <br> <br>\r\n\r\n    <h2>Hoe meld ik mij aan? </h2>\r\n    <section>Je kan op onze website aanmelden via de registratie knop op de hoofdpagina. Bij de registratie moet je aan een aantal voorwaarden voldoen om een intakegesprek te plannen. Na de intakegesprek ben je succesvol aangemeld. \r\n    </section> <br> <br>\r\n\r\n    <h2>Hoe kan ik chatten met mijn hulpverlener? </h2>\r\n    <section>Na de login, verschijnt er een chat-icoon die jou de mogelijkheid biedt om met hulpverlener privé te chatten. Of je kan mij altijd mailen naar mariannevandijk@ZMDH.nl \r\n    </section> <br> <br>\r\n\r\n    <h2>Hoe kan ik deelnemen aan de groepschat?</h2>\r\n    <section>Na de login verschijnt er een chat-icoon die jou de mogelijkheid biedt om deel te nemen aan een groepschat. </section> <br> <br>\r\n\r\n</article> <br><br>\r\n",
                            PictureUrl = "https://i.postimg.cc/wTSpbR8c/Marianne-Van-Dijk-Orthopedagoog.png",
                            Specialty = "Dyslexie"
                        });
                });

            modelBuilder.Entity("ChatClient", b =>
                {
                    b.HasOne("WDPR_A.Models.Chat", null)
                        .WithMany()
                        .HasForeignKey("ChatsCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WDPR_A.Models.Client", null)
                        .WithMany()
                        .HasForeignKey("ClientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClientGuardian", b =>
                {
                    b.HasOne("WDPR_A.Models.Client", null)
                        .WithMany()
                        .HasForeignKey("ClientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WDPR_A.Models.Guardian", null)
                        .WithMany()
                        .HasForeignKey("GuardiansId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WDPR_A.Models.Appointment", b =>
                {
                    b.HasOne("WDPR_A.Models.Client", "IncomingClient")
                        .WithMany()
                        .HasForeignKey("IncomingClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WDPR_A.Models.Orthopedagogue", "Orthopedagogue")
                        .WithMany("Appointments")
                        .HasForeignKey("OrthopedagogueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IncomingClient");

                    b.Navigation("Orthopedagogue");
                });

            modelBuilder.Entity("WDPR_A.Models.Chat", b =>
                {
                    b.HasOne("WDPR_A.Models.Orthopedagogue", "Orthopedagogue")
                        .WithMany("Chats")
                        .HasForeignKey("OrthopedagogueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Orthopedagogue");
                });

            modelBuilder.Entity("WDPR_A.Models.Message", b =>
                {
                    b.HasOne("WDPR_A.Models.Chat", "Chat")
                        .WithMany("Messages")
                        .HasForeignKey("ChatCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chat");
                });

            modelBuilder.Entity("WDPR_A.Models.Guardian", b =>
                {
                    b.HasOne("WDPR_A.Models.Appointment", null)
                        .WithMany("Guardians")
                        .HasForeignKey("AppointmentId");
                });

            modelBuilder.Entity("WDPR_A.Models.Appointment", b =>
                {
                    b.Navigation("Guardians");
                });

            modelBuilder.Entity("WDPR_A.Models.Chat", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("WDPR_A.Models.Orthopedagogue", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Chats");
                });
#pragma warning restore 612, 618
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using WebApplication.Entities;

namespace WebApplication.Models
{
    public class GamePortalDbContext : DbContext
    {
        public DbSet<Option> Options { get; set; }
        public DbSet<Navigate> Navigates { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostTags> PostTags { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Role> Roles{ get; set; }
        public DbSet<User> Users{ get; set; }
        public DbSet<UserInfo> UsersInfo { get; set; }

        public DbSet<ChangePasswordRequest> ChangePasswordRequests { get; set; }


        public GamePortalDbContext(DbContextOptions options) : base(options)
        {
                  //Database.EnsureDeleted();
                  //Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-FCNTCRS\SQLEXPRESS;Initial Catalog=gamePortal;Integrated Security=True;MultipleActiveResultSets=True");
            //optionsBuilder.EnableSensitiveDataLogging(true);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Option>(entity =>
            {
                entity.HasIndex(o => o.Name).IsUnique();
            });

            modelBuilder.Entity<Platform>(entity =>
            {
                entity.HasIndex(p => p.Name).IsUnique();
                entity.HasIndex(p => p.Slug).IsUnique();
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.HasIndex(t => t.Name).IsUnique();
                entity.HasIndex(t => t.Slug).IsUnique();
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasIndex(c => c.Slug).IsUnique();
            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.HasIndex(g => g.Slug).IsUnique();
            });
            modelBuilder.Entity<Post>(entity =>
            {
                entity.HasIndex(p => p.Slug).IsUnique();
            });

			modelBuilder.Entity<Role>(entity =>
			{
				entity.HasIndex(r => r.Name).IsUnique();
			});

			modelBuilder.Entity<User>(entity =>
			{
				entity.HasIndex(u => u.Email).IsUnique();
				entity.HasIndex(u => u.Login).IsUnique();
			});

			modelBuilder.Entity<UserInfo>(entity =>
			{
				entity.HasIndex(ui => ui.PhoneNumber).IsUnique();
				entity.HasIndex(u => u.UserId).IsUnique();
			});

            ChangePasswordRequest[] changePasswordRequests = new ChangePasswordRequest[]
            {
                new ChangePasswordRequest
                {
                    Id = 1,
                }
            };

            modelBuilder.Entity<ChangePasswordRequest>().HasData(changePasswordRequests);

            Option[] options = new Option[]
            {
                new Option()
                {
                    Id = 1,
                    Name = "siteName",
                    Key = "",
                    Value = "Крутые Грушки - Супер Игровой Портал",
                    IsSystem = true,
                    Order = 1
                },
                new Option()
                {
                    Id = 2,
                    Name = "siteDescription",
                    Key = "",
                    Value = "Сдесь Вы найдете абсолютно Все и по любой игровой тематике. Мы - клондайк Игромана",
                    IsSystem = true,
                    Order = 2
                },
                new Option()
                {
                    Id = 3,
                    Name = "siteLogo",
                    Key = "",
                    Value = "/images/logo.png",
                    IsSystem = true,
                    Order = 1
                },
                new Option()
                {
                    Id = 4,
                    Name = "Facebook",
                    Key = "https://www.facebook.com/?locale=ru_RU",
                    Value = @"<svg class='svg-inline--fa fa-facebook fa-w-14' aria-hidden='true' data-prefix='fab' data-icon='facebook' role='img' xmlns='http://www.w3.org/2000/svg' viewBox='0 0 448 512'><path fill='currentColor' d='M448 56.7v398.5c0 13.7-11.1 24.7-24.7 24.7H309.1V306.5h58.2l8.7-67.6h-67v-43.2c0-19.6 5.4-32.9 33.5-32.9h35.8v-60.5c-6.2-.8-27.4-2.7-52.2-2.7-51.6 0-87 31.5-87 89.4v49.9h-58.4v67.6h58.4V480H24.7C11.1 480 0 468.9 0 455.3V56.7C0 43.1 11.1 32 24.7 32h398.5c13.7 0 24.8 11.1 24.8 24.7z'</path></svg>",
                    Order = 1,
                    Relation = "socialLinks"
                },
                new Option()
                {
                    Id = 5,
                    Name = "Twitter",
                    Key = "https://x.com/?lang=ru",
                    Value = @"<svg class=""svg-inline--fa fa-twitter fa-w-16"" aria-hidden=""true"" data-prefix=""fab"" data-icon=""twitter"" role=""img"" xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 512 512""><path fill=""currentColor"" d=""M459.37 151.716c.325 4.548.325 9.097.325 13.645 0 138.72-105.583 298.558-298.558 298.558-59.452 0-114.68-17.219-161.137-47.106 8.447.974 16.568 1.299 25.34 1.299 49.055 0 94.213-16.568 130.274-44.832-46.132-.975-84.792-31.188-98.112-72.772 6.498.974 12.995 1.624 19.818 1.624 9.421 0 18.843-1.3 27.614-3.573-48.081-9.747-84.143-51.98-84.143-102.985v-1.299c13.969 7.797 30.214 12.67 47.431 13.319-28.264-18.843-46.781-51.005-46.781-87.391 0-19.492 5.197-37.36 14.294-52.954 51.655 63.675 129.3 105.258 216.365 109.807-1.624-7.797-2.599-15.918-2.599-24.04 0-57.828 46.782-104.934 104.934-104.934 30.213 0 57.502 12.67 76.67 33.137 23.715-4.548 46.456-13.32 66.599-25.34-7.798 24.366-24.366 44.833-46.132 57.827 21.117-2.273 41.584-8.122 60.426-16.243-14.292 20.791-32.161 39.308-52.628 54.253z""></path></svg>",
                    Order = 2,
                    Relation = "socialLinks"
                },
                new Option()
                {
                    Id = 6,
                    Name = "Steam",
                    Key = "https://store.steampowered.com/?l=russian",
                    Value = @"<svg class=""svg-inline--fa fa-steam fa-w-16"" aria-hidden=""true"" data-prefix=""fab"" data-icon=""steam"" role=""img"" xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 496 512"" data-fa-i2svg=""><path fill=""currentColor"" d=""M496 256c0 137-111.2 248-248.4 248-113.8 0-209.6-76.3-239-180.4l95.2 39.3c6.4 32.1 34.9 56.4 68.9 56.4 39.2 0 71.9-32.4 70.2-73.5l84.5-60.2c52.1 1.3 95.8-40.9 95.8-93.5 0-51.6-42-93.5-93.7-93.5s-93.7 42-93.7 93.5v1.2L176.6 279c-15.5-.9-30.7 3.4-43.5 12.1L0 236.1C10.2 108.4 117.1 8 247.6 8 384.8 8 496 119 496 256zM155.7 384.3l-30.5-12.6a52.79 52.79 0 0 0 27.2 25.8c26.9 11.2 57.8-1.6 69-28.4 5.4-13 5.5-27.3.1-40.3-5.4-13-15.5-23.2-28.5-28.6-12.9-5.4-26.7-5.2-38.9-.6l31.5 13c19.8 8.2 29.2 30.9 20.9 50.7-8.3 19.9-31 29.2-50.8 21zm173.8-129.9c-34.4 0-62.4-28-62.4-62.3s28-62.3 62.4-62.3 62.4 28 62.4 62.3-27.9 62.3-62.4 62.3zm.1-15.6c25.9 0 46.9-21 46.9-46.8 0-25.9-21-46.8-46.9-46.8s-46.9 21-46.9 46.8c.1 25.8 21.1 46.8 46.9 46.8z""></path></svg>",
                    Order = 3,
                    Relation = "socialLinks"
                },
            };
            modelBuilder.Entity<Option>().HasData(options);

            Navigate[] navigates = new Navigate[]
            {
                new Navigate(){ Id = 1, Title = "Main", Href="/", Order = 1, Parent_Id = null },
                new Navigate(){ Id = 2, Title = "Blog", Href="/blog", Order = 2, Parent_Id = null },
                new Navigate(){ Id = 3, Title = "Gallery", Href="/gallety", Order = 3, Parent_Id = null },
                new Navigate(){ Id = 4, Title = "Tournaments", Href="/tournaments", Order = 4, Parent_Id = null },
                new Navigate(){ Id = 5, Title = "Store", Href="/store", Order = 5, Parent_Id = null },
                new Navigate(){ Id = 6, Title = "Forum", Href="/forum", Order = 1, Parent_Id = 1 },
                new Navigate(){ Id = 7, Title = "Coming Soon", Href="/blog/coming", Order = 2, Parent_Id = 1 },
                new Navigate(){ Id = 8, Title = "News", Href="/blog/news", Order = 1, Parent_Id = 2 },
                new Navigate(){ Id = 9, Title = "Archive", Href="/blog/archive", Order = 2, Parent_Id = 2 },
                new Navigate(){ Id = 10, Title = "Teams", Href="/tournaments/teans", Order = 1, Parent_Id = 4 },
                new Navigate(){ Id = 11, Title = "Teammate", Href="/tournaments/teammate", Order = 2, Parent_Id = 4 },

                new Navigate(){ Id = 12, Title = "New games", Href="blog/newgames", Order = 2, Parent_Id = 8 },
                new Navigate(){ Id = 13, Title = "Hacked games", Href="blog/hackedgames", Order = 2, Parent_Id = 8 },
                new Navigate(){ Id = 14, Title = "Game distribution", Href="blog/distribution", Order = 2, Parent_Id = 8 },
            };
            modelBuilder.Entity<Navigate>().HasData(navigates);

            Platform[] platforms = new Platform[]
            {
                new Platform(){Id=1, Name="PC", ImgAlt="PC Platform", ImgSrc="/images/icon-mouse.png", Slug="pc_platform"},
                new Platform(){Id=2, Name="XBOX", ImgAlt="XBOX Platform", ImgSrc="/images/icon-gamepad.png", Slug="xbox_platform"},
                new Platform(){Id=3, Name="PS", ImgAlt="PS Platform", ImgSrc="/images/icon-gamepad-2.png", Slug="ps_platform"},
                new Platform(){Id=4, Name="Android", ImgAlt="Android Platform", ImgSrc="/images/android.png", Slug="android_platform"},
                new Platform(){Id=5, Name="Nintendo", ImgAlt="Nintendo Platform", ImgSrc="/images/nintendo.png", Slug="nintendo_platform"}
            };
            modelBuilder.Entity<Platform>().HasData(platforms);

            Tag[] tags = new Tag[]
            {
                new Tag(){Id=1, Name="Резня", Slug="Massacre"},
                new Tag(){Id=2, Name="Розовые сопли", Slug="Pink_snot"},
                new Tag(){Id=3, Name="Кровавая битва", Slug="Bloody_battle"},
                new Tag(){Id=4, Name="До конца", Slug="To_end"},
                new Tag(){Id=5, Name="Турнир", Slug="Tournament"},
                new Tag(){Id=6, Name="Соник", Slug="Sonic"},
                new Tag(){Id=7, Name="Фентези", Slug="Fantasy"},
                new Tag(){Id=8, Name="Бесплатная игра", Slug="Free_game"},
                new Tag(){Id=9, Name="Тактика", Slug="Tactics"},
                new Tag(){Id=10, Name="Стратегия", Slug="Strategy"},
                new Tag(){Id=11, Name="Браузерная", Slug="Browser"},
                new Tag(){Id=12, Name="Онлайн", Slug="Online"}
            };
            modelBuilder.Entity<Tag>().HasData(tags);

            Genre[] genres = new Genre[]
            {
                new Genre() {Id=1, Name="ACTION", Slug="ACTION"},
                new Genre() {Id=2, Name="MMO", Slug="MMO"},
                new Genre() {Id=3, Name="STRATEGY", Slug="STRATEGY"},
                new Genre() {Id=4, Name="ADVENTURE", Slug="ADVENTURE"},
                new Genre() {Id=5, Name="RACING", Slug="RACING"},
                new Genre() {Id=6, Name="Beat ’em up", Slug="Beat_em_up"},
                new Genre() {Id=7, Name="Fighting", Slug="Fighting"},
                new Genre() {Id=8, Name="Flight simulation", Slug="Flight_simulation"},
                new Genre() {Id=9, Name="Role-playing (RPG)", Slug="RPG"},
                new Genre() {Id=10, Name="Stealth", Slug="Stealth"},
                new Genre() {Id=11, Name="Survival horror", Slug="Survival_horror"}
            };
            modelBuilder.Entity<Genre>().HasData(genres);

            Category[] categories = new Category[]
            {
                new Category() {Id=1, Name="Создатели", Description="", Slug="creators", ParentId = null},
                new Category() {Id=2, Name="Gabe Newell", Description="", Slug="gabe_newell", ParentId = 1},
                new Category() {Id=3, Name="Marc Laidlaw", Description="", Slug="marc_laidlaw", ParentId = 1},
                new Category() {Id=4, Name="Robin Walker", Description="", Slug="robin_walker", ParentId = 1},
                new Category() {Id=5, Name="Разработчики", Description="", Slug="dewelopers", ParentId = null},
                new Category() {Id=6, Name="Feral Interactive", Description="", Slug="Feral_Interactive", ParentId = 5},
                new Category() {Id=7, Name="Ubisoft", Description="", Slug="Ubisoft", ParentId = 5},
                new Category() {Id=8, Name="Valve Software", Description="", Slug="Valve_Software", ParentId = 5},
                new Category() {Id=9, Name="Electronic Arts", Description="", Slug="Electronic_Arts", ParentId = 5},
                new Category() {Id=10, Name="Square Enix", Description="Capcom", Slug="Square_Enix", ParentId = 5},
                new Category() {Id=11, Name="Aspyr Media", Description="", Slug="Aspyr_Media", ParentId = 5},
                new Category() {Id=12, Name="Bethesda Softworks", Description="", Slug="Bethesda_Softworks", ParentId = 5},
                new Category() {Id=13, Name="Telltale Games", Description="", Slug="Telltale_Games", ParentId = 5},
                new Category() {Id=14, Name="Nintendo", Description="", Slug="Nintendo", ParentId = 5},
            };
            modelBuilder.Entity<Category>().HasData(categories);

            Post[] posts = new Post[]
            {
                new Post() {
                    Id=1, Status=PostStatus.Published, PlatformId=1, CategoryId=7, GenreId=1,
                    Title="Far Cry 3",
                    Description="По мере развития технологий игры с открытым миром становятся все богаче и насыщеннее, а их превосходство над линейными играми – все более ярко выраженным. Far Cry 3 – прекрасный тому пример. Грамотно сочетая в себе удачные элементы двух предыдущих эпизодов (не считая консольную спин-офф серию Instincts), этот шутер вполне ожидаемо – и заслуженно – становится фаворитом в своем жанре.",
                    Content="Как и в первой игре, дело снова происходит на тропическом архипелаге, однако теперь вместо мутантов и наемников нам предлагают истреблять пиратов, которые похитили родных и близких главного героя Джейсона. Любопытно, что авторы отказались от типичной схемы «главный герой – бывший военный»: протагонист и его компания – просто случайно попавшие на остров туристы; завязка изрядно напоминает книгу «Пляж». Решение довольно-таки спорное, так как стремительная метаморфоза молодого благополучного экстремала в безжалостного и сверхэффективного головореза не выглядит убедительной, сколько ты ни впихивай в оформление символических бабочек и ни корми его галлюциногенным грибами под рассуждения о «пути воина».",
                    Slug="far_cry_3",
                    ImgSrc = "/images/games/farcry_3.webp",
                    ImgAlt = "Far Cry 3"
                },
                new Post() {
                    Id=2, Status=PostStatus.Published, PlatformId=1, CategoryId=7, GenreId=2,
                    Title="GRAB YOUR SWORD AND FIGHT THE HORDE",
                    Description="For good, too; though, in consequence of my previous emotions, I was still occasionally seized with a stormy sob . After we had jogged on for some little time, I asked the carrier...",
                    Content="Just then her head struck against the roof of the hall: in fact she was now more than nine feet high, and she at once took up the little golden key and hurried off to the garden door. The first question of course was, how to get dry again: they had a consultation about this, and after a few minutes it seemed quite natural to Alice to find herself talking familiarly with them, as if she had known them all her life. Indeed, she had quite a long argument with the Lory, who at last turned sulky, and would only say, `I am older than you, and must know better'; and this Alice would not allow without knowing how old it was, and, as the Lory positively refused to tell its age, there was no more to be said.",
                    Slug="grab_your_sword_and_fight_the_horde",
                    ImgSrc = "/images/post-2.jpg",
                    ImgAlt = "GRAB YOUR SWORD AND FIGHT THE HORDE"
                },
                new Post() {
                    Id=3, Status=PostStatus.Published, PlatformId=1, CategoryId=7, GenreId=2,
                    Title="AT LENGTH ONE OF THEM CALLED OUT IN A CLEAR",
                    Description="For good, too; though, in consequence of my previous emotions, I was still occasionally seized with a stormy sob . After we had jogged on for some little time, I asked the carrier...",
                    Content="Just then her head struck against the roof of the hall: in fact she was now more than nine feet high, and she at once took up the little golden key and hurried off to the garden door. The first question of course was, how to get dry again: they had a consultation about this, and after a few minutes it seemed quite natural to Alice to find herself talking familiarly with them, as if she had known them all her life. Indeed, she had quite a long argument with the Lory, who at last turned sulky, and would only say, `I am older than you, and must know better'; and this Alice would not allow without knowing how old it was, and, as the Lory positively refused to tell its age, there was no more to be said.",
                    Slug="at_lenght_one_of_them",
                    ImgSrc = "/images/post-7-mid-square.jpg",
                    ImgAlt = "AT LENGTH ONE OF THEM CALLED OUT IN A CLEAR"
                },
                new Post() {
                    Id=4, Status=PostStatus.Published, PlatformId=1, CategoryId=7, GenreId=2,
                    Title="SMELL MAGIC IN THE AIR. OR MAYBE BARBECUE",
                    Description="With what mingled joy and sorrow do I take up the pen to write to my dearest friend! Oh, what a change between to-day and yesterday! Now I am friendless and alone...",
                    Content="Just then her head struck against the roof of the hall: in fact she was now more than nine feet high, and she at once took up the little golden key and hurried off to the garden door. The first question of course was, how to get dry again: they had a consultation about this, and after a few minutes it seemed quite natural to Alice to find herself talking familiarly with them, as if she had known them all her life. Indeed, she had quite a long argument with the Lory, who at last turned sulky, and would only say, `I am older than you, and must know better'; and this Alice would not allow without knowing how old it was, and, as the Lory positively refused to tell its age, there was no more to be said.",
                    Slug="smell_magic_in_the_air",
                    ImgSrc = "/images/post-1-mid.jpg",
                    ImgAlt = "SMELL MAGIC IN THE AIR. OR MAYBE BARBECUE"
                },
                new Post() {
                    Id=5, Status=PostStatus.Published, PlatformId=1, CategoryId=7, GenreId=1,
                    Title="WE FOUND A WITCH! MAY WE BURN HER?",
                    Description="And she went on planning to herself how she would manage it. `They must go by the carrier,' she thought; `and how funny it'll seem, sending presents to one's own feet!...",
                    Content="Just then her head struck against the roof of the hall: in fact she was now more than nine feet high, and she at once took up the little golden key and hurried off to the garden door. The first question of course was, how to get dry again: they had a consultation about this, and after a few minutes it seemed quite natural to Alice to find herself talking familiarly with them, as if she had known them all her life. Indeed, she had quite a long argument with the Lory, who at last turned sulky, and would only say, `I am older than you, and must know better'; and this Alice would not allow without knowing how old it was, and, as the Lory positively refused to tell its age, there was no more to be said.",
                    Slug="we_found_a_witch",
                    ImgSrc = "/images/post-3-mid.jpg",
                    ImgAlt = "WE FOUND A WITCH! MAY WE BURN HER?"
                },
                new Post() {
                    Id=6, Status=PostStatus.Published, PlatformId=1, CategoryId=7, GenreId=3,
                    Title="FOR GOOD, TOO THOUGH, IN CONSEQUENCE",
                    Description="This little wandering journey, without settled place of abode, had been so unpleasant to me, that my own house, as I called it to myself, was a perfect settlement to me compared to that...",
                    Content="Just then her head struck against the roof of the hall: in fact she was now more than nine feet high, and she at once took up the little golden key and hurried off to the garden door. The first question of course was, how to get dry again: they had a consultation about this, and after a few minutes it seemed quite natural to Alice to find herself talking familiarly with them, as if she had known them all her life. Indeed, she had quite a long argument with the Lory, who at last turned sulky, and would only say, `I am older than you, and must know better'; and this Alice would not allow without knowing how old it was, and, as the Lory positively refused to tell its age, there was no more to be said.",
                    Slug="foor_good_too_thought",
                    ImgSrc = "/images/post-4-mid.jpg",
                    ImgAlt = "FOR GOOD, TOO THOUGH, IN CONSEQUENCE"
                },
                new Post() {
                    Id=7, Status=PostStatus.Published, PlatformId=1, CategoryId=7, GenreId=3,
                    Title="HE MADE HIS PASSENGER CAPTAIN OF ONE",
                    Description="Just then her head struck against the roof of the hall: in fact she was now more than nine feet high, and she at once took up the little golden key and hurried off to the garden door...",
                    Content="Just then her head struck against the roof of the hall: in fact she was now more than nine feet high, and she at once took up the little golden key and hurried off to the garden door. The first question of course was, how to get dry again: they had a consultation about this, and after a few minutes it seemed quite natural to Alice to find herself talking familiarly with them, as if she had known them all her life. Indeed, she had quite a long argument with the Lory, who at last turned sulky, and would only say, `I am older than you, and must know better'; and this Alice would not allow without knowing how old it was, and, as the Lory positively refused to tell its age, there was no more to be said.",
                    Slug="he_made_his_passenger",
                    ImgSrc = "/images/post-5-mid.jpg",
                    ImgAlt = "HE MADE HIS PASSENGER CAPTAIN OF ONE"
                },
                new Post() {
                    Id=8, Status=PostStatus.Published, PlatformId=1, CategoryId=7, GenreId=4,
                    Title="AT FIRST, FOR SOME TIME, I WAS NOT ABLE TO ANSWER",
                    Description="This little wandering journey, without settled place of abode, had been so unpleasant to me, that my own house, as I called it to myself, was a perfect settlement to me compared to that...",
                    Content="Just then her head struck against the roof of the hall: in fact she was now more than nine feet high, and she at once took up the little golden key and hurried off to the garden door. The first question of course was, how to get dry again: they had a consultation about this, and after a few minutes it seemed quite natural to Alice to find herself talking familiarly with them, as if she had known them all her life. Indeed, she had quite a long argument with the Lory, who at last turned sulky, and would only say, `I am older than you, and must know better'; and this Alice would not allow without knowing how old it was, and, as the Lory positively refused to tell its age, there was no more to be said.",
                    Slug="at_first_for_some_time",
                    ImgSrc = "/images/post-6-mid.jpg",
                    ImgAlt = "AT FIRST, FOR SOME TIME, I WAS NOT ABLE TO ANSWER"
                },
                new Post() {
                    Id=9, Status=PostStatus.Published, PlatformId=1, CategoryId=7, GenreId=5,
                    Title="AT LENGTH ONE OF THEM CALLED OUT IN A CLEAR",
                    Description="TJust then her head struck against the roof of the hall: in fact she was now more than nine feet high, and she at once took up the little golden key and hurried off to the garden door...",
                    Content="Just then her head struck against the roof of the hall: in fact she was now more than nine feet high, and she at once took up the little golden key and hurried off to the garden door. The first question of course was, how to get dry again: they had a consultation about this, and after a few minutes it seemed quite natural to Alice to find herself talking familiarly with them, as if she had known them all her life. Indeed, she had quite a long argument with the Lory, who at last turned sulky, and would only say, `I am older than you, and must know better'; and this Alice would not allow without knowing how old it was, and, as the Lory positively refused to tell its age, there was no more to be said.",
                    Slug="at_length",
                    ImgSrc = "/images/post-7-mid.jpg",
                    ImgAlt = "AT LENGTH ONE OF THEM CALLED OUT IN A CLEAR"
                },
                new Post() {
                    Id=10, Status=PostStatus.Published, PlatformId=1, CategoryId=7, GenreId=7,
                    Title="FOR GOOD, TOO THOUGH, IN CONSEQUENCE",
                    Description="This little wandering journey, without settled place of abode, had been so unpleasant to me, that my own house, as I called it to myself, was a perfect settlement to me compared to that...",
                    Content="Just then her head struck against the roof of the hall: in fact she was now more than nine feet high, and she at once took up the little golden key and hurried off to the garden door. The first question of course was, how to get dry again: they had a consultation about this, and after a few minutes it seemed quite natural to Alice to find herself talking familiarly with them, as if she had known them all her life. Indeed, she had quite a long argument with the Lory, who at last turned sulky, and would only say, `I am older than you, and must know better'; and this Alice would not allow without knowing how old it was, and, as the Lory positively refused to tell its age, there was no more to be said.",
                    Slug="in_consencuence",
                    ImgSrc = "/images/post-8-mid.jpg",
                    ImgAlt = "FOR GOOD, TOO THOUGH, IN CONSEQUENCE"
                },
                new Post() {
                    Id=11, Status=PostStatus.Published, PlatformId=1, CategoryId=7, GenreId=4,
                    Title="HE MADE HIS PASSENGER CAPTAIN OF ONE",
                    Description="Just then her head struck against the roof of the hall: in fact she was now more than nine feet high, and she at once took up the little golden key and hurried off to the garden door...",
                    Content="Just then her head struck against the roof of the hall: in fact she was now more than nine feet high, and she at once took up the little golden key and hurried off to the garden door. The first question of course was, how to get dry again: they had a consultation about this, and after a few minutes it seemed quite natural to Alice to find herself talking familiarly with them, as if she had known them all her life. Indeed, she had quite a long argument with the Lory, who at last turned sulky, and would only say, `I am older than you, and must know better'; and this Alice would not allow without knowing how old it was, and, as the Lory positively refused to tell its age, there was no more to be said.",
                    Slug="his_passenger",
                    ImgSrc = "/images/post-9-mid.jpg",
                    ImgAlt = "HE MADE HIS PASSENGER CAPTAIN OF ONE"
                }
            };
            modelBuilder.Entity<Post>().HasData(posts);

            List<PostTags> postTags = new List<PostTags>();
            Random random = new Random();
            int counter = 1;
            for (int i = 0; i < posts.Length; i++)
            {
                for (int j = 0; j < tags.Length; j++)
                {
                    postTags.Add(
                            new PostTags() { Id = counter, PostId = i + 1, TagId = j + 1 }
                        );
                    counter++;
                }
            }
            modelBuilder.Entity<PostTags>().HasData(postTags);


            Comment[] comments = new Comment[]
            {
                new Comment(){Id = 1, PostId = 1, ParentId = null, IsValid = true,
                    VisitorName = "Alex", VisitorEmail = "alex@alex.gmail.com",
                    Subject="Игра Гавно. Роблох сила!", Text = "Я поиграл часа два и забросил. Игра полный шлак. Удалите ее и не вспоминайте" },

                new Comment(){Id = 2, PostId = 1, ParentId = null, IsValid = true,
                    VisitorName = "Maria", VisitorEmail = "maria@aivanova.gmail.com",
                    Subject="Фар Край! Фар Край! Силааа!", Text = "А мне очень понравилась. Я прошла ее всю и даже завалила главного босса." },

                new Comment(){Id = 3, PostId = 1, ParentId = null, IsValid = true,
                    VisitorName = "Pedro", VisitorEmail = "pedro@gonzales.mexico.com",
                    Subject="Игра огонь! Мочи гринго!", Text = "Я её прошел аж три раза. Облазил все локации полностью. Нашел каждую нычку" },

                new Comment(){Id = 4, PostId = 1, ParentId = 1, IsValid = true,
                    VisitorName = "superMan", VisitorEmail = "supre20071505@gmail.com.com",
                    Subject="Сам ты гавно! Играть научись!", Text = "Ну ты и нубяра! Ты РобЛОХ :)" },

                new Comment(){Id = 5, PostId = 1, ParentId = 1, IsValid = true,
                    VisitorName = "Jonn Doe", VisitorEmail = "jondoo@gmail.com.com",
                    Subject="Козлики, хватит бодаться:) ", Text = "И да, РобЛОХ действительно говно" },

                new Comment(){Id = 6, PostId = 1, ParentId = 5, IsValid = true,
                    VisitorName = "Maria", VisitorEmail = "maria@aivanova.gmail.com",
                    Subject="Мальчики Тупые: ) ", Text = "ахах я Вас нубяр сама сделаю!" },

                new Comment(){Id = 7, PostId = 1, ParentId = 3, IsValid = true,
                    VisitorName = "Black Hero", VisitorEmail = "blackgay@gmail.com",
                    Subject="Набираю в команду игракофф", Text = "Буду оберегать, лелеять и заботиться." },

            };
            modelBuilder.Entity<Comment>().HasData(comments);

            Role[] roles = new Role[]
            {
                new Role() {Id=1, Name="Reader"},
                new Role() {Id=2, Name="Editor"},
                new Role() {Id=1001, Name="Admin"},
            };
			modelBuilder.Entity<Role>().HasData(roles);

            User[] users = new User[]
            {
                new User()
                {
                    Id=1, 
                    Login="Boob", 
                    Email="boob@istwuud.com.ua", 
                    Password="$MYHASH$V1$10000$swxFCmUV1ic5FKJcFu4FXDGvZc6172ghsSr2aEyJ+rHRJEU6", 
                    RoleId=1
                },
				new User()
				{
					Id=2,
					Login="Mary",
					Email="mary@bigtits.com.ua",
					Password="$MYHASH$V1$10000$swxFCmUV1ic5FKJcFu4FXDGvZc6172ghsSr2aEyJ+rHRJEU6",
					RoleId=2
				},
				new User()
				{
					Id=3,
					Login="Bond",
					Email="James@bond007.com.ua",
					Password="qwerty1234567890",
					RoleId=1001
				},
                new User()
                {
                    Id=4,
                    Login="Weesfer",
                    Email="landiknikita@gmail.com",
                    Password="qwerty1234567890",
                    RoleId=1001
                },
            };
			modelBuilder.Entity<User>().HasData(users);

            UserInfo[] userInfos = new UserInfo[]
            {
                new UserInfo(){Id=1, UserId=1, Avatar="/admin/media/avatars/300-23.jpg", 
                    Name="Боб", Surname="Мартин", PhoneNumber="+3806889587524", Info="Умеет читать и Пиииисать"},
                new UserInfo(){Id=2, UserId=2, Avatar="/admin/media/avatars/300-14.jpg", 
                    Name="Мария", Surname="Дьюрк", PhoneNumber="+380547859855", Info="Спасительница и розхитительница магазинов"},
                new UserInfo(){Id=3, UserId=3, Avatar="/admin/media/avatars/300-1.jpg",     
                    Name="Джеймс", Surname="Бонд", PhoneNumber="+3806684656865", Info="Агент со справкой номер 7",
                    Address="Главная Башня Семи Дроздов", CompanyTitle="Спасители - Асенизаторы", CompanySite="helperGumus@com", 
                    JobTitle="Главный Ассенизатор", Country="Планета Криптон"},
                new UserInfo(){Id=4, UserId=4, Avatar="/admin/media/avatars/300-1.jpg",
                    Name="Джеймс", Surname="Никитович", PhoneNumber="+3806684656866", Info="Агент со справкой номер 7",
                    Address="Главная Башня Семи Дроздов", CompanyTitle="Спасители - Асенизаторы", CompanySite="helperGumus@com",
                    JobTitle="Главный Ассенизатор", Country="Планета Криптон"},
            };
			modelBuilder.Entity<UserInfo>().HasData(userInfos);

		}
    }
}

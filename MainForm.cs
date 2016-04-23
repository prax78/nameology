/*
 * Created by SharpDevelop.
 * User: narayanan
 * Date: 4/22/2016
 * Time: 11:52 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace win_namelogy
{
	
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public int run=0;
	
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			if(richTextBox1.Text!="")
			{richTextBox1.Clear();
				
				
				
			}
			string name=textBox1.Text.ToString().ToLower();
			char[] na=name.ToCharArray();
			int i=0;
			foreach(char naa in na)
			{
				if(naa!=' ')
				{
					
					switch(naa)
					{
						case 'a':
						case 'j':
						case 's':
							i=i+1;
							break;
						case 'b':
						case 'k':
						case 't':
							i=i+2;
							break;
						case 'c':
						case 'l':
						case 'u':
							i=i+3;
							break;	
							case 'd':
						case 'm':
						case 'v':
							i=i+4;
							break;
							case 'e':
						case 'n':
						case 'w':
							i=i+5;
							break;
						case 'f':
						case 'o':
						case 'x':
							i=i+6;
							break;
								case 'g':
						case 'p':
						case 'y':
							i=i+7;
							break;
								case 'h':
						case 'q':
						case 'z':
							i=i+8;
							break;
								case 'i':
						case 'r':
						
							i=i+9;
							break;
					}
			
				}
			}
			
			strint(i.ToString());
			display(name);
			
		}
		public int strint(string s)
		{
			//Console.WriteLine(s);
			run=0;
			char[] con=s.ToCharArray();
			foreach(char c in con)
			{
				run+=Convert.ToInt32(c.ToString());
				
							}
			//return run;
			
			if(run==11)
			{
				return run;
			}
			
			if((run >9))
			{
				string ss=Convert.ToString(run);
				
				strint(ss);
				
				return run;
			}
			
			else{
				return run;
			}
			
		}
		
		public void display(string b)
		{
			switch(run)
			{
					case 1:
					
				//	Console.WriteLine("your name :{0} and your number is : {1} and your qualities are",b,run);
				//	Console.WriteLine("Initiating action, pioneering, leading, independent, attaining, individual");
				richTextBox1.AppendText("Your Name is "+b+" Your Nameology Number is "+run);
				richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("Your characteristics  are below");
				richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("Initiating action, pioneering, leading, independent, attaining, individual");
				richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("The expression or destiny for #1:");
				richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("A number 1 Expression denotes the skilled executive with keen administrative capabilities. You must develop the capacity to be a fine leader, sales executive, or promoter. You have the tools to become an original person with a creative approach to problem solving, and a penchant for initiating action. Someone may have to follow behind you to handle the details, but you know how to get things going and make things happen. You have a good mind and the ability to use it for your advancement. Because of these factors, you have much potential for achievement and financial rewards. Frequently, this expression belongs to one running a business or striving to achieve a level of accomplishment on ones talents and efforts. You have little need for much supervision, preferring to act on your own with little restraint. You are both ambitious and determined. Self-confident and self-reliant must be yours, as you develop a strong unyielding will and the courage of your convictions.Although you fear loneliness, you want to be left alone. You fear routine and being in a rut. You often jump the gun because you are afraid of being left behind.The negative attributes of the 1 Expression are egotism and a self-centered approach to life. This is an aggressive number and if it is over-emphasized it is very hard to live with. You do not have to be overly aggressive to fulfill your destiny. The 1 has a natural instinct to dominate and to be the boss; adhering to the concept of being number One. Again, you do not have to dominate and destroy in order to lead and manage.");
				richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("Your Soul Urge number is: 1");
				richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("Your Soul Urge is the number 1. With a Soul Urge number of 1, you want to lead and direct, to work independent of supervision, by yourself or with subordinates. You take pride in your abilities and want to be recognized for them. You may seek opportunities to display your strength and usefulness, wanting to create and originate. In your desire to manage the big picture and the main issues, you may often leave the details to others.The positive 1 Soul Urge is Ambitious and determined, a leader seeking opportunities. There is a great deal of honesty and loyalty in this character. If you possess positive 1 Soul Urge qualities, you are very attainment oriented and driven to success. You are a loyal friend and strictly fair in your business dealings.The negative side of the 1 Soul Urge must be avoided. A negative 1 is apt to dominate situations and people; the home, the spouse, the family and the business. Emotions aren't strong in this nature. If you possess an excess of 1 energy, you may, at times, be boastful aegotistic. You must avoid being too critical and impatient of trifles. The great need of the 1 Soul Urge is the development of friendliness, and a sincere interest in people.");
				//richTextBox1.AppendText(Environment.NewLine);
				//richTextBox1.AppendText("Your Inner Dream number #1 is: An Inner Dream number of means.");


				break;
					
					case 2:
				//	Console.WriteLine("your name :{0} and your number is : {1} and your qualities are",b,run);
				//	Console.WriteLine("Cooperation, adaptability, consideration of others, partnering, mediating");
				richTextBox1.AppendText("Your Name is "+b+" Your Nameology Number is "+run);
				richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("Your characteristics are below");
				richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("Cooperation, adaptability, consideration of others, partnering, mediating");
				richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("The expression or destiny for #2:");
				richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("A number 2 Expression gives you the tools to work very well with other people. Your destiny is in the role of the mediator and the peacemaker. In many ways you are dependent on others and seem to function best in a partnership or in some form of group activity. Modesty runs deep in your nature, and you can work comfortably without recognition of your accomplishments. Often, others get credit for your ideas, and this is of little real concern to your since you are such a willing team player. As you grow in this direction, you become sensitive to the feelings of others, you are ever diplomatic in handling complicated situations. Cooperative, courteous, and considerate, you have the capacity to become an outstanding facilitator. You know how to organize and handle people. You are a good detail person because you rarely overlook anything. Tactful and friendly, nearly everyone likes you.The negative 2 personality can be over-sensitive and easily hurt. Too much of this number in your makeup can make you very shy and uncertain. Sometimes the excessive 2 energies makes one apathetic and somewhat indifferent to the job at hand; the ability to handle details is hampered in these cases.");
				richTextBox1.AppendText(Environment.NewLine);
				//richTextBox1.AppendText("Your Soul Urge number is: 2");
				//richTextBox1.AppendText(Environment.NewLine);
				//richTextBox1.AppendText("Your Soul Urge is the number 1. With a Soul Urge number of 1, you want to lead and direct, to work independent of supervision, by yourself or with subordinates. You take pride in your abilities and want to be recognized for them. You may seek opportunities to display your strength and usefulness, wanting to create and originate. In your desire to manage the big picture and the main issues, you may often leave the details to others.The positive 1 Soul Urge is Ambitious and determined, a leader seeking opportunities. There is a great deal of honesty and loyalty in this character. If you possess positive 1 Soul Urge qualities, you are very attainment oriented and driven to success. You are a loyal friend and strictly fair in your business dealings.The negative side of the 1 Soul Urge must be avoided. A negative 1 is apt to dominate situations and people; the home, the spouse, the family and the business. Emotions aren't strong in this nature. If you possess an excess of 1 energy, you may, at times, be boastful aegotistic. You must avoid being too critical and impatient of trifles. The great need of the 1 Soul Urge is the development of friendliness, and a sincere interest in people.");
				richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("An Inner Dream number of 2 means:You dream of close and meaningful relationships, cooperation with those around you; family and friends. You want to be a peacemaker and mediator. You present an image that you are a very pliable and easygoing person who would be very easy to get along with.");
			
				break;
					
					case 3:
				//Console.WriteLine("your name :{0} and your number is : {1} and your qualities are",b,run);
					//Console.WriteLine("Expression, verbalization, socialization, the arts, the joy of living.");
					richTextBox1.AppendText("Your Name is "+b+" Your Nameology Number is "+run);
					richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("Your characteristics  are below");
				richTextBox1.AppendText(Environment.NewLine);
					richTextBox1.AppendText("Expression, verbalization, socialization, the arts, the joy of living.");
					richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("The expression or destiny for #3:");
				richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("An Expression of 3 produces a quest for destiny with words along a variety of lines that may include writing, speaking, singing, acting or teaching; our entertainers, writers, litigators, teachers, salesmen, and composers. You also have the destiny to sell yourself or sell just about any product that comes along. You are imaginative in your presentation, and you may have creative talents in the arts, although these are more likely to be latent. You are an optimistic person that seems ever enthusiastic about life and living. You are friendly, loving and social, and people like you because you are charming and such a good conversationalist. Your ability to communicate may often inspire others. It is your role in life to inspire and motivate; to raise the spirits of those around you.The negative side of number 3 Expression is superficiality. You may tend to scatter your forces and simply be too easygoing. It is advisable for the negative 3 to avoid dwelling on trivial matters, especially gossip.");
				richTextBox1.AppendText(Environment.NewLine);
				//richTextBox1.AppendText("Your Soul Urge number is: 2");
				//richTextBox1.AppendText(Environment.NewLine);
				//richTextBox1.AppendText("Your Soul Urge is the number 1. With a Soul Urge number of 1, you want to lead and direct, to work independent of supervision, by yourself or with subordinates. You take pride in your abilities and want to be recognized for them. You may seek opportunities to display your strength and usefulness, wanting to create and originate. In your desire to manage the big picture and the main issues, you may often leave the details to others.The positive 1 Soul Urge is Ambitious and determined, a leader seeking opportunities. There is a great deal of honesty and loyalty in this character. If you possess positive 1 Soul Urge qualities, you are very attainment oriented and driven to success. You are a loyal friend and strictly fair in your business dealings.The negative side of the 1 Soul Urge must be avoided. A negative 1 is apt to dominate situations and people; the home, the spouse, the family and the business. Emotions aren't strong in this nature. If you possess an excess of 1 energy, you may, at times, be boastful aegotistic. You must avoid being too critical and impatient of trifles. The great need of the 1 Soul Urge is the development of friendliness, and a sincere interest in people.");
				richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("An Inner Dream number of 3 means:You dream of artistic expression; writing, painting, music. You would seek to more freely express your inner feeling and obtain more enjoyment from life. You also dream of being more popular, likable, and appreciated.");
			
					break;
					
					case 4:
					//Console.WriteLine("your name :{0} and your number is : {1} and your qualities are",b,run);
				//Console.WriteLine("A foundation, order, service, struggle against limits, steady growth.");
				richTextBox1.AppendText("Your Name is "+b+" Your Nameology Number is "+run);
				richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("Your characteristics  are below");
				richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("A foundation, order, service, struggle against limits, steady growth.");
					richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("The expression or destiny for #4:");
				richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("Order, service, and management are the cornerstones of the number 4 Expression. Your destiny is to express wonderful organization skills with your ever practical, down-to-earth approach. You are the kind of person who is always willing to work those long, hard hours to push a project through to completion. A patience with detail allows you to become expert in fields such as building, engineering, and all forms of craftsmanship. Your abilities to write and teach may lean toward the more technical and detailed. In the arts, music will likely be your choice. Artistic talents may also appear in such fields as horiculture and floral arrangement, as well. Many skilled physicians and especially surgeons have the 4 Expression.The positive attitudes of the 4 Expression yield responsibility; you are one who no doubt, fulfills obligations, and is highly systematic and orderly. You are serious and sincere, honest and faithful. It is your role to help and you are required to do a good job at everything you undertake.If there is too much 4 energies present in your makeup, you may express some of the negative attitudes of the number 4. The obligations that you face may tend to create frustration and feelings of limitation or restriction. You may sometimes find yourself nursing negative attitudes in this regard and these can keep you in a rather low mood. Avoid becoming too rigid, stubborn, dogmatic, and fixed in your opinions. You may have a tendency to develop and hold very strong likes and dislikes, and some of these may border on the classification of prejudice. The negative side of 4 often produces dominant and bossy individuals who use disciplinarian to an excess. These tendencies must be avoided. Finally, like nearly all with 4 Expression, you must keep your eye on the big picture and not get overly wrapped up in detail and routine.");
				richTextBox1.AppendText(Environment.NewLine);
				//richTextBox1.AppendText("Your Soul Urge number is: 2");
				//richTextBox1.AppendText(Environment.NewLine);
				//richTextBox1.AppendText("Your Soul Urge is the number 1. With a Soul Urge number of 1, you want to lead and direct, to work independent of supervision, by yourself or with subordinates. You take pride in your abilities and want to be recognized for them. You may seek opportunities to display your strength and usefulness, wanting to create and originate. In your desire to manage the big picture and the main issues, you may often leave the details to others.The positive 1 Soul Urge is Ambitious and determined, a leader seeking opportunities. There is a great deal of honesty and loyalty in this character. If you possess positive 1 Soul Urge qualities, you are very attainment oriented and driven to success. You are a loyal friend and strictly fair in your business dealings.The negative side of the 1 Soul Urge must be avoided. A negative 1 is apt to dominate situations and people; the home, the spouse, the family and the business. Emotions aren't strong in this nature. If you possess an excess of 1 energy, you may, at times, be boastful aegotistic. You must avoid being too critical and impatient of trifles. The great need of the 1 Soul Urge is the development of friendliness, and a sincere interest in people.");
				richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("An Inner Dream number of 4 means:You dream of being a very solid citizen that people can depend upon. You strive for organization and predictable order. You want to be recognized as a person with a plan and the discipline to make that plan work like clockwork.");
			
				break;
					
					case 5:
					//Console.WriteLine("your name :{0} and your number is : {1} and your qualities are",b,run);
					//Console.WriteLine("Expansiveness, visionary, adventure, the constructive use of freedom.");
				richTextBox1.AppendText("Your Name is "+b+" Your Nameology Number is "+run);
				richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("Your characteristics  are below");
				richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("Expansiveness, visionary, adventure, the constructive use of freedom.");
					richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("The expression or destiny for #5:");
				richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("The number 5 Expression endows with the wonderful characteristic of multi-talents and versatility. You can do so many things well. The tone of the number 5 is constructive freedom, and in your drive to attain this freedom, you will likely be the master of adaptability and change. You are good at presenting ideas and knowing how to approach people to get what you want. Naturally, this gives you an edge in any sort of selling game and spells easy success when it comes to working with people in most jobs. Your popularity may lead you toward some form of entertainment or amusement. Whatever you do, you are clever, analytical, and a very quick thinker.If there is too much of the 5 energy in your makeup, you may express some the negative attitudes of the number. Your restless and impatient attitude may keep you from staying with any project for too long. Sometimes you can be rather erratic and scatter yourself and your energies. You have a hard time keeping regular office hours and maintaining any sort of a routine.You tend to react strongly if you sense that your freedom of speech or action is being impaired or restricted in any way. As clever as you are, you may have a tendency to make the same mistakes over and over again because much of your response is glib reaction rather that thoughtful application. You are in a continuous state of flux brought by constantly changing interests.");

				richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("Your Soul Urge number is: 5");
				richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("A Soul Urge number of 5 means:The 5 soul urge or motivation would like to follow a life of freedom, excitement, adventure and unexpected happening. The idea of travel and freedom to roam intrigues you. You are very much the adventurer at heart. Not particularly concerned about your future or about getting ahead, you can seem superficial and unmotivated.In a positive sense, the energies of the number 5 make you very adaptable and versatile. You have a natural resourcefulness and enthusiasm that may mark you as a progressive with a good mind and active imagination. You seem to have a natural inclination to be a pace-setter. You are attracted to the unusual and the fast paced.You may be overly restless and impatient at times. You may dislike the routine work that you are engaged in, and tend to jump from activity to activity, without ever finishing anything. You may have difficulty with responsibility. You don't want to be tied down to a relationship, and it may be hard to commit to one person.");

			//	richTextBox1.AppendText(Environment.NewLine);
			//	richTextBox1.AppendText("An Inner Dream number of 4 means:You dream of being a very solid citizen that people can depend upon. You strive for organization and predictable order. You want to be recognized as a person with a plan and the discipline to make that plan work like clockwork.");
				
				break;
					
					case 6:
					//Console.WriteLine("your name :{0} and your number is : {1} and your qualities are",b,run);
					//Console.WriteLine("Responsibility, protection, nurturing, community, balance, sympathy.");
					richTextBox1.AppendText("Your Name is "+b+" Your Nameology Number is "+run);
					richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("Your characteristics  are below");
				richTextBox1.AppendText(Environment.NewLine);
					richTextBox1.AppendText("Responsibility, protection, nurturing, community, balance, sympathy.");
						richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("The expression or destiny for #6:");
				richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("The number 6 Expression provides you a truly outstanding sense of responsibility, love, and balance. The 6 is helpful and ever conscientious, making you quite capable of rectifying and balancing any sort of inharmonious situation. You are a person very much inclined to give help and comfort to those in need. You have a natural penchant for working with the old, the young, the sick, or the underprivileged. Although you may have considerable creative and artistic talents, the chances are that you will devote yourself to an occupation that shows concern for the betterment of the community.The positive side of the number 6 suggests that you are very loving, friendly, and appreciative of others. You have a depth of understanding that produces much sympathetic, kindness, and generosity. The qualities of the 6 make the finest and most concerned parent and one often deeply involved in domestic activities. Openness and honesty is apparent in your approach to all relationships.If there is an excess of the number 6 in your makeup, you may exhibit some of the negative traits associated with this number. There may be a tendency for you to be too exacting and demanding of yourself. In this regard, you may at times sacrifice yourself (or your loved ones) for the welfare of others. In some cases, the over zealous 6 has difficulty distinguishing helping from interfering. You may have difficulty expressing your own individuality, because of involvement with responsibilities and causes. Like all with the Expression of the number 6, it's quite likely that you worry much too much.");
				richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("An Inner Dream number of 6 means:You dream of guiding and fostering the perfect family in the perfect home. You crave the devotion from offspring and a loving spouse. You picture yourself in the center of a successful domestic unit.");

			//	richTextBox1.AppendText(Environment.NewLine);
			//	richTextBox1.AppendText("An Inner Dream number of 4 means:You dream of being a very solid citizen that people can depend upon. You strive for organization and predictable order. You want to be recognized as a person with a plan and the discipline to make that plan work like clockwork.");
				
					break;
					
					case 7:
					//Console.WriteLine("your name :{0} and your number is : {1} and your qualities are",b,run);
					//Console.WriteLine("Analysis, understanding, knowledge, awareness, studious, meditating.");
					richTextBox1.AppendText("Your Name is "+b+" Your Nameology Number is "+run);
					richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("Your characteristics  are below");
				richTextBox1.AppendText(Environment.NewLine);
					//richTextBox1.AppendText("Analysis, understanding, knowledge, awareness, studious, meditating.");
					richTextBox1.AppendText("The expression or destiny for #7:");
				richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("Thought, analysis, introspection, and seclusiveness are all characteristics of the expression number 7. The hallmark of the number 7 is a good mind, and especially good at searching out and finding the truth. You are so very capable of analyzing, judging and discriminating, that very little ever escapes your observation and deep understanding. You are the type of person that can really get involved in a search for wisdom or hidden truths, often becoming an authority on whatever it is your are focusing on. This can easily be of a technical or scientific nature, or it may be religious or occult, it matters very little, you pursue knowledge with the same sort of vigor. You can make a very fine teacher, or because of a natural inclination toward the spiritual, you may become deeply emerged in religious affairs or even psychic explorations. You tend to operate on a rather different wavelength, and many of your friends may not really know you very well. The positive aspects of the 7 expression are that you can be a rue perfectionist in a very positive sense of the word. You are very logical, and usually employ a quite rational approach to most things you do. You can be so rational at times that you almost seem to lack emotion, and when you are faced with an emotional situation, you may have a bit of a problem coping with it. You have excellent capabilities to study and learn really deep and difficult subjects, and to search for hidden fundamentals. At full maturity you are likely to be a very peaceful and poised individual.If there is an over supply of the number 7 in your makeup, the negative aspects of the number may be apparent. The chief negative of 7 relates to the limited degree of trust that you may have in people. A tendency to be highly introverted can make you a bit on the self-centered side, certainly very much self-contained . Because of this, you are not very adaptable, and you may tend to be overly critical and intolerant. You really like to work alone, at your own pace and in your own way. You neither show or understand emotions very well.");
				richTextBox1.AppendText(Environment.NewLine);
								richTextBox1.AppendText("An Inner Dream number of 7 means:You dream of having the opportunity to read, study, and shut yourself off from worldly distractions. You can see yourself as a teacher, mystic, or ecclesiastic, spending your life in the pursuit of knowledge and learning.");

			//	richTextBox1.AppendText(Environment.NewLine);
			//	richTextBox1.AppendText("An Inner Dream number of 4 means:You dream of being a very solid citizen that people can depend upon. You strive for organization and predictable order. You want to be recognized as a person with a plan and the discipline to make that plan work like clockwork.");
				
					break;
					
					case 8:
				//	Console.WriteLine("your name :{0} and your number is : {1} and your qualities are",b,run);
				//	Console.WriteLine("Practical endeavors, status oriented, power-seeking, high-material goals.");
				richTextBox1.AppendText("Your Name is "+b+" Your Nameology Number is "+run);
				richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("Your characteristics  are below");
				richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("Practical endeavors, status oriented, power-seeking, high-material goals.");
				richTextBox1.AppendText(Environment.NewLine);
				//	richTextBox1.AppendText("Analysis, understanding, knowledge, awareness, studious, meditating.");
					richTextBox1.AppendText("The expression or destiny for #8:");
				richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("Your Expression is represented by the number 8. The 8 Expression is well-equipped in a managerial sense. You have outstanding organizational and administrative capabilities. You have the potential for considerable achievement in business or other powerful positions. You can expect to receive the financial and material rewards. You have the skill and abilities to establish or operate a business with great efficiency. You have good judgment when it comes to money and commercial matters, and you understand how to build and accumulate material wealth. Much of your success (or lack of it) may come due to your ability (or inability) to judge character. With the number 8 Expression, you exercise sound judgment in most of your affairs; you are realistic and practical in your approach to business matters.The positive 8 Expression produces individuals that are very ambitious and goal-oriented. If the 8 energy is not in excess in your makeup, you will no doubt express these traits to some extent. No one has any more energy that a person with the 8 Expression who has a plan laid and is starting to work. No one has any more self-confidence, either. If you are expressing the positive qualities of 8, you are an outstanding manager because you can plan, initiate, and complete projects; you are very dependable and determined.As it always happens, there can be too much of a good thing. If you have too much of the 8 energy in your makeup, you may express some of the negative attitudes. A negative 8 can be very rigid and stubborn. Ambition sometimes has a way of becoming over-ambition, and you may express an unreasonable impatience with the lack of progress. If your negative side is showing, you may be too exacting, both of yourself and of others. Sometimes this can even becomes a case of intolerance.The number 8 is very materialistic and also very desirous of status and power. Neither of these drives are inherently negative unless they are taken to an extreme. You must avoid the tendency to strain after money, material matters, status, or power, to the detriment of the other important factors in your life.");
				richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("An Inner Dream number of 8 means:You dream of success in the business or political world, of power and control of large material endeavors. You crave authority and recognition of executive skills. Your secret self may have very strong desire to become an entrepreneur.");

				break;
					
					case 9:
					//Console.WriteLine("your name :{0} and your number is : {1} and your qualities are",b,run);
					//Console.WriteLine("Humanitarian, giving nature, selflessness, obligations, creative expression.");
					richTextBox1.AppendText("Your Name is "+b+" Your Nameology Number is "+run);
					richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("Your characteristics  are below");
				richTextBox1.AppendText(Environment.NewLine);
					richTextBox1.AppendText("Humanitarian, giving nature, selflessness, obligations, creative expression.");
					richTextBox1.AppendText(Environment.NewLine);
					//richTextBox1.AppendText("Analysis, understanding, knowledge, awareness, studious, meditating.");
					richTextBox1.AppendText("The expression or destiny for #9:");
				richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("The expression that you exhibit is represented by the number 9. Your talents center in humanistic interests and approaches. You like to help others as you were intended to be the 'big brother or big sister' type. You operate best when you follow your feelings and sense of compassion, and allow yourself to be sensitive to the needs of others. You work well with people, and have the potential to inspire. This suggests that you could successfully teach or counsel. Creative ability, imagination and artistic talent (often latent) of the highest order are present in this expression. It's possible that you're not using or developing all of these capabilities at this time. Some of your talents may have been used at an earlier time in your life, and some may still be latent. Be aware of your capabilities, so that you can make use of them at appropriate times.If you are able to achieve the potential of your natural expression in this life, you are capable of much human understanding and have a lot to give to others. Your personal ambitions are likely to be maintained in a very positive perspective, never losing sight of an interest in people, and a sympathetic, tolerant, broad-minded and compassionate point of view. You are quite idealistic, and disappointed at the lack of perfection in the world. You have a strong awareness of your own feeling as well as those of others. Friendships, affection, and love are extremely important.Undeveloped or ignored, the negative side of the 9 expression can be very selfish and self-centered. If you do not actively involve yourself with work that benefits others, you may tend to express just the opposite characteristics. It is your role to be very involved with other people and their needs, but it may be difficult for you achieve this role. Aloofness, lack of involvement, and a lack of sensitivity mark the low road of this expression.");
				richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("A Soul Urge number of 9 means:With a 9 Soul Urge, you want to give to others, usually in a humanitarian or philanthropic manner. You are highly motivated to give friendship, affection and love. And you are generous in giving of your knowledge and experience. You have very sharing urges, and you are likely to have a great deal to share. Your concern for others makes you a very sympathetic and generous person with a sensitive and compassionate nature.You are able to view life in very broad and intuitive terms. You often express high ideals and an inspirational approach to life. If you are able to fully realize the potential of your motivation, you will be a very self-sacrificing person who is able to give freely without being concerned about any return or reward.As with all human beings, you are prone to sometimes express the negative attitudes inherent to your Soul Urges. You may become too sensitive and tend to express emotions strongly at times. There can be significant conflict between higher aims and personal ambitions. You may resent the idea of giving all of the time and, in fact, if there is too much 9 energy in your nature you may reject the idea. You may often be disappointed in the lack of perfection in yourself and others.");

					break;
					
					case 11:
				//	Console.WriteLine("your name :{0} and your number is : {1} and your qualities are",b,run);
				//	Console.WriteLine("Higher spiritual plane, intuitive, illumination, idealist, a dreamer.");
				richTextBox1.AppendText("Your Name is "+b+" Your Nameology Number is "+run);
				richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("Your characteristics  are below");
				richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("Higher spiritual plane, intuitive, illumination, idealist, a dreamer.");
						richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("The expression or destiny for #11:");
				richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("Your Expression number is 11. The number 11 is the first of the master numbers. It is associated with idealistic concepts and rather spiritual issues. Accordingly, it is a number with potentials that are somewhat more difficult to live up to. You have the capacity to be inspirational, and the ability to lead merely by your own example. An inborn inner strength and awareness can make you an excellent teacher, social worker, philosopher, or advisor. No matter what area of work you pursue, you are very aware and sensitive to the highest sense of your environment. Your intuition is very strong; in fact, many psychic people and those involved in occult studies have the number 11 expression. You possess a good mind with keen analytical ability. Because of this you can probably succeed in most lines of work, however, you will do better and be happier outside of the business world. Oddly enough, even here you generally succeed, owing to your often original and unusual approach. Nonetheless, you are more content working with your ideals, rather than dollars and cents.The positive aspect of the number 11 expression is an always idealistic attitude. Your thinking is long term, and you are able to grasp the far-reaching effects of actions and plans. You are disappointed by the shortsighted views of many of your contemporaries. You are deeply concerned and supportive of art, music, or of beauty in any form.The negative attitudes associated with the number 11 expression include a continuous sense of nervous tension; you may be too sensitive and temperamental. You tend to dream a lot and may be more of a dreamer than a doer. Fantasy and reality sometimes become intermingled and you are sometimes very impractical. You tend to want to spread the illumination of your knowledge to others irrespective of their desire or need.");

				richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("Your Soul Urge number is: 2");
				richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("A Soul Urge number of 2 means:With the Soul Urge number 2, your motivation is centered on friendships, partnerships, and companionship. You want to work with others as a part of a cooperative team. Leadership is not important to you, but making a contribution to the team effort is. You are willing to work hard to achieve a harmonious environment with sensitive, genial people.In a positive sense, the 2 Soul Urge is sympathetic, extremely concerned and devoted. The nature tends to be very sensitive to others, always tactful and diplomatic. This element in your nature indicates that you are rather emotional. You are persuasive, but in a very quiet way, never forceful. You are the type that makes really close friendships because you are so affectionate and loving.If this number is over-emphasized in your makeup, you may be over-sensitive, with a delicate ego that is too easily hurt. You may be timid or fearful, too easygoing for your own good.");

				richTextBox1.AppendText(Environment.NewLine);
				richTextBox1.AppendText("Your Inner Dream number is: 9 An Inner Dream number of 9 means:You dream of being creative, intellectual, and universal; the selfless humanitarian. You understand the needy and want to help them. You would love to be a person people count on for support and advice.");
				
				break;
					
					default:
				richTextBox1.Text="Error ,Wrong Input";
					break;
				
			}
			}
		void RichTextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace YanaBirthday
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page5 : ContentPage
    {
        String[] jokes;
        Random ind;
        public Page5()
        {
            InitializeComponent();
            BindingContext = this;
            ind = new Random();
            jokes = new String[50];
            jokes[0] = "What kind of shoes do socks wear?\n OPEN TOAD SANDALS!";
            jokes[1] = "What do you call a bee who is having a really bad hair day?\n A FRIS-BEE";
            jokes[2] = "What rock group has four guys who don't sing?\n MOUNT RUSHMORE";
            jokes[3] = "I made a Chemistry joke...there was no REACTION [is this u right now]!";
            jokes[4] = "How do astronomers party?\n They plan-et";
            jokes[5] = "Why can't you trust an atom?\n Because they make up everything!";
            jokes[6] = "What do clouds do when they get rich?\n They make it rain!";
            jokes[7] = "Want to hear a Potassium joke?\n K.";
            jokes[8] = "Helium walks into a bar and asks for a drink. The bartender says, \"Sorry, we don't serve noble gases here.\" Helium doesn't react.";
            jokes[9] = "Why are atoms Catholic?\n Because they have mass...";
            jokes[10] = "Two hydrogen atoms are at a party and bump into each other. The first one says, \"Hey, grab that electron, it's mine!\" \"How do you know?\" asks the second. \"'Cause I'm positive!\" the first replies.";
            jokes[11] = "A neutron walks into a pastry shop and asks for a brownie. How much?\" asked the neutron. The shopkeeper says, \"For you, no charge!\"";
            jokes[12] = "What did one tectonic plate say to another when they bumped into each other?\n \"Sorry, my fault!\"";
            jokes[13] = "They have just found the gene for shyness. They would have found it earlier, but it was hiding behind two other genes.";
            jokes[14] = "Why can't you argue with Pi?\n It's irrational.";
            jokes[15] = "How much room do fungi need to grow?\n As mushroom as possible.";
            jokes[16] = "Should I make any jokes about Sodium?\n Na.";
            jokes[17] = "Why do chemists love EDM?\n They love to drop the base.";
            jokes[18] = "What do you call it when a geologist has to work on a Friday night?\n Gin and tectonics.";
            jokes[19] = "How many tickles does it take to make an octopus laugh?\n Ten tickles.";
            jokes[20] = "How does a penguin build its house?\n Igloos it together.";
            jokes[21] = "I'm on a seafood diet. I see food and I eat it.";
            jokes[22] = "I used to hate facial hair...but then it grew on me.";
            jokes[23] = "What did the fish say when he hit the wall?\n Dam.";
            jokes[24] = "Which state has the most roads?\n Rhode Island.";
            jokes[25] = "Why couldn't the bicycle stand up by itself?\n It was two tired.";
            jokes[26] = "How does Moses make his coffee?\n Hebrews it. [OFIR JOKE]";
            jokes[27] = "When I was a kid, my mother told me I could be anyone I wanted to be. Turns out, identity theft is a crime.";
            jokes[28] = "Which is faster, hot or cold?\n Hot, because you can catch a cold.";
            jokes[29] = "What does a baby computer call his father? Data.";
            jokes[30] = "Wanna hear a joke about paper? Never mind—it's tearable.";
            jokes[31] = "What do you get from a pampered cow? Spoiled milk!";
            jokes[32] = "How do moths swim? Using the butterfly stroke.";
            jokes[33] = "I made a pencil with two erasers. It was pointless.";
            jokes[34] = "What’s that Nevada city where all the dentists visit?\n Floss Vegas.";
            jokes[35] = "What do you call a hippie's wife?\n Mississippi.";
            jokes[36] = "The rotation of earth really makes my day.";
            jokes[37] = "Why do we tell actors to \"break a leg?\"?\n Because every play has a cast.";
            jokes[38] = "A woman in labor suddenly shouted, \"Shouldn’t! Wouldn’t! Couldn’t! Didn’t! Can’t!\" \"Don’t worry,\" said the doc. \"Those are just contractions.\"";
            jokes[39] = "Did you hear about the actor who fell through the floorboards? He was just going through a stage.";
            jokes[40] = "Did you hear about the claustrophobic astronaut? He just needed a little space.";
            jokes[41] = "Where are average things manufactured?\n The satis-factory.";
            jokes[42] = "A man tells his doctor, \"Doc, help me. I’m addicted to Twitter!\" The doctor replies, \"Sorry, I don't follow...\" ";
            jokes[43] = "What do you call a parade of rabbits hopping backwards?\n A receding hare-line.";
            jokes[44] = "What do you call a pony with a cough?\n A little horse.";
            jokes[45] = "What did the pirate say when he turned 80?\nAye matey.";
            jokes[46] = "What is an astronaut’s favorite part on a computer?\nThe space bar.";
            jokes[47] = "Why did the hipster burn his mouth?\nHe drank the coffee before it was cool.";
            jokes[48] = "Why did the Oreo go to the dentist?\nBecause he lost his filling.";
            jokes[49] = "What do you call a number that can’t keep still?\nA roamin’ numeral.";
        }

        

        public void onGenerateClicked(object sender, EventArgs e)
        {
            int index = ind.Next(0, jokes.Length);
            Joke.Text = jokes[index];
        }

        async void onMainClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
    }
}
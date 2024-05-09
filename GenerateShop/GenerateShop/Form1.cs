namespace GenerateShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox10.Text = "\r\n" +
                "   '" + materalTextBox.Text + "':\r\n" +
                "      material: " + materalTextBox.Text + "\r\n" +
                "      slot: " + slotTextBox.Text + "\r\n" +
                "      amount: " + countTextBox.Text + "\r\n" +
                "      display_name: \"&7\"\r\n" +
                "      lore:\r\n";

            if (countBuyOneTextBox.Text != "" && countBuyStackTextBox.Text == "")
            {
                textBox10.Text += "         - '&7&8ЛКМ&a Купить " + name_itemTextBox.Text + " &7- &e[" + priceBuyStackTextBox.Text + "$]'\r\n"
                    + "         - '&7       лкм купить " + countBuyOneTextBox.Text + " " + name_itemTextBox.Text + "'\r\n";
            }
            else if (countBuyOneTextBox.Text == "" && countBuyStackTextBox.Text != "")
            {
                textBox10.Text += "         - '&7&8ЛКМ&a Купить " + name_itemTextBox.Text + " &7- &e[" + priceBuyOneTextBox.Text + "$]'\r\n"
                    + "         - '&7       лкм купить " + countBuyStackTextBox.Text + " " + name_itemTextBox.Text + " за " + priceBuyStackTextBox.Text + "$'\r\n";
            }
            else if (countBuyOneTextBox.Text != "" && countBuyStackTextBox.Text != "")
            {
                textBox10.Text += "         - '&7&8ЛКМ&a Купить " + name_itemTextBox.Text + " &7- &e[" + priceBuyOneTextBox.Text + "$]'\r\n"
                    + "         - '&7       лкм купить " + countBuyOneTextBox.Text + " " + name_itemTextBox.Text + "'\r\n"
                    + "         - '&7       шифт+лкм купить " + countBuyStackTextBox.Text + " " + name_itemTextBox.Text + " за " + priceBuyStackTextBox.Text + "$'\r\n";
            }


            if (countSellOneTextBox.Text != "" && countSellStackTextBox.Text == "")
            {
                textBox10.Text += "         - '&7'\r\n         - '&7&8ПКМ&2 Продать " + name_itemTextBox.Text + " &7- &e[" + priceSellOneTextBox.Text + "$]'\r\n"
                    + "         - '&7       пкм продать " + countSellOneTextBox.Text + name_itemTextBox.Text + "'\r\n";
            }
            else if (countSellOneTextBox.Text == "" && countSellStackTextBox.Text != "")
            {
                textBox10.Text += "         - '&7'\r\n         - '&7&8ПКМ&2 Продать " + name_itemTextBox.Text + " &7- &e[" + priceSellStackTextBox.Text + "$]'\r\n"
                    + "         - '&7       пкм продать 64 " + name_itemTextBox.Text + " за " + priceSellStackTextBox.Text + "$'\r\n";
            }
            else if (countSellOneTextBox.Text != "" && countSellStackTextBox.Text != "")
            {
                textBox10.Text += "         - '&7'\r\n         - '&7&8ПКМ&2 Продать " + name_itemTextBox.Text + " &7- &e[" + priceSellOneTextBox.Text + "$]'\r\n"
                    + "         - '&7       пкм продать " + countSellOneTextBox.Text + " " + name_itemTextBox.Text + "'\r\n"
                    + "         - '&7       шифт+пкм продать " + countSellStackTextBox.Text + " " + name_itemTextBox.Text + " за " + priceSellStackTextBox.Text + "$'\r\n";
            }


            if (countBuyOneTextBox.Text != "" && countBuyStackTextBox.Text == "")
            {
                textBox10.Text += "         - '&7'\r\n\r\n" +
                        "      left_click_requirement:\r\n" +
                        "         requirements:\r\n" +
                        "            has_money:\r\n" +
                        "               type: has money\r\n" +
                        "               amount: " + priceBuyOneTextBox.Text + "\r\n" +
                        "         deny_commands:\r\n" +
                        "            - '[message] &b[S] &rФермер: &cЯ не для бедных старался'\r\n" +
                        "            - '[sound] ENTITY_VILLAGER_NO'\r\n" +
                        "      left_click_commands:\r\n" +
                        "         - '[console] give %player_name% " + materalTextBox.Text + " " + countBuyOneTextBox.Text + "'\r\n" +
                        "         - '[takemoney] " + priceBuyOneTextBox.Text + "'\r\n" +
                        "      shift_left_click_requirement:\r\n" +
                        "         requirements:\r\n" +
                        "            has_money:\r\n" +
                        "               type: has money\r\n" +
                        "               amount: " + priceBuyOneTextBox.Text + "\r\n" +
                        "         deny_commands:\r\n" +
                        "            - '[message] &b[S] &rФермер: &cЯ не для бедных старался'\r\n" +
                        "            - '[sound] ENTITY_VILLAGER_NO'\r\n" +
                        "      shift_left_click_commands:\r\n" +
                        "         - '[console] give %player_name% " + materalTextBox.Text + " " + countBuyOneTextBox.Text + "'\r\n" +
                        "         - '[takemoney] " + priceBuyOneTextBox.Text + "'\r\n";
            }
            else if (countBuyOneTextBox.Text == "" && countBuyStackTextBox.Text != "")
            {
                textBox10.Text += "         - '&7'\r\n\r\n" +
                        "      left_click_requirement:\r\n" +
                        "         requirements:\r\n" +
                        "            has_money:\r\n" +
                        "               type: has money\r\n" +
                        "               amount: " + priceBuyStackTextBox.Text + "\r\n" +
                        "         deny_commands:\r\n" +
                        "            - '[message] &b[S] &rФермер: &cЯ не для бедных старался'\r\n" +
                        "            - '[sound] ENTITY_VILLAGER_NO'\r\n" +
                        "      left_click_commands:\r\n" +
                        "         - '[console] give %player_name% " + materalTextBox.Text + " " + countBuyStackTextBox.Text + "'\r\n" +
                        "         - '[takemoney] " + priceBuyStackTextBox.Text + "'\r\n" +
                        "      shift_left_click_requirement:\r\n" +
                        "         requirements:\r\n" +
                        "            has_money:\r\n" +
                        "               type: has money\r\n" +
                        "               amount: " + priceBuyStackTextBox.Text + "\r\n" +
                        "         deny_commands:\r\n" +
                        "            - '[message] &b[S] &rФермер: &cЯ не для бедных старался'\r\n" +
                        "            - '[sound] ENTITY_VILLAGER_NO'\r\n" +
                        "      shift_left_click_commands:\r\n" +
                        "         - '[console] give %player_name% " + materalTextBox.Text + " " + countBuyStackTextBox.Text + "'\r\n" +
                        "         - '[takemoney] " + priceBuyStackTextBox.Text + "'\r\n";
            }
            else if (countBuyOneTextBox.Text != "" && countBuyStackTextBox.Text != "")
            {
                textBox10.Text += "         - '&7'\r\n\r\n" +
                        "      left_click_requirement:\r\n" +
                        "         requirements:\r\n" +
                        "            has_money:\r\n" +
                        "               type: has money\r\n" +
                        "               amount: " + priceBuyOneTextBox.Text + "\r\n" +
                        "         deny_commands:\r\n" +
                        "            - '[message] &b[S] &rФермер: &cЯ не для бедных старался'\r\n" +
                        "            - '[sound] ENTITY_VILLAGER_NO'\r\n" +
                        "      left_click_commands:\r\n" +
                        "         - '[console] give %player_name% " + materalTextBox.Text + " " + countBuyOneTextBox.Text + "'\r\n" +
                        "         - '[takemoney] " + priceBuyOneTextBox.Text + "'\r\n" +
                        "      shift_left_click_requirement:\r\n" +
                        "         requirements:\r\n" +
                        "            has_money:\r\n" +
                        "               type: has money\r\n" +
                        "               amount: " + priceBuyStackTextBox.Text + "\r\n" +
                        "         deny_commands:\r\n" +
                        "            - '[message] &b[S] &rФермер: &cЯ не для бедных старался'\r\n" +
                        "            - '[sound] ENTITY_VILLAGER_NO'\r\n" +
                        "      shift_left_click_commands:\r\n" +
                        "         - '[console] give %player_name% " + materalTextBox.Text + " " + countBuyStackTextBox.Text + "'\r\n" +
                        "         - '[takemoney] " + priceBuyStackTextBox.Text + "'\r\n";
            }


            if (countSellOneTextBox.Text != "" && countSellStackTextBox.Text == "")
            {
                textBox10.Text +=
                       "      right_click_requirement:\r\n" +
                       "         requirements:\r\n" +
                       "            has_item:\r\n" +
                       "               type: has item\r\n" +
                       "               material: " + materalTextBox.Text + "\r\n" +
                       "               amount: " + countSellOneTextBox.Text + "\r\n" +
                       "         deny_commands:\r\n" +
                       "            - '[message] &b[S] &rФермер: &cПринеси хоть что-то'\r\n" +
                       "            - '[sound] ENTITY_VILLAGER_NO'\r\n" +
                       "      right_click_commands:\r\n" +
                       "         - '[console] clear %player_name% " + materalTextBox.Text + " " + countSellOneTextBox.Text + "'\r\n" +
                       "         - '[givemoney] " + priceSellOneTextBox.Text + "'\r\n" +
                       "         - '[message] &aВы продали &6" + countSellOneTextBox.Text + " " + name_itemTextBox.Text + " &aза " + priceSellOneTextBox.Text + "$'\r\n" +
                       "      shift_right_click_requirement:\r\n" +
                       "         requirements:\r\n" +
                       "            has_item:\r\n" +
                       "               type: has item\r\n" +
                       "               material: " + materalTextBox.Text + "\r\n" +
                       "               amount: " + countSellOneTextBox.Text + "\r\n" +
                       "         deny_commands:\r\n" +
                       "            - '[message] &b[S] &rФермер: &cПринеси хоть что-то'\r\n" +
                        "            - '[sound] ENTITY_VILLAGER_NO'\r\n" +
                       "      shift_right_click_commands:\r\n" +
                       "         - '[console] clear %player_name% " + materalTextBox.Text + " " + countSellOneTextBox.Text + "'\r\n" +
                       "         - '[givemoney] " + priceSellOneTextBox.Text + "'\r\n";
            }
            else if (countSellOneTextBox.Text == "" && countSellStackTextBox.Text != "")
            {
                textBox10.Text +=
                       "      right_click_requirement:\r\n" +
                       "         requirements:\r\n" +
                       "            has_item:\r\n" +
                       "               type: has item\r\n" +
                       "               material: " + materalTextBox.Text + "\r\n" +
                       "               amount: " + countSellStackTextBox.Text + "\r\n" +
                       "         deny_commands:\r\n" +
                       "            - '[message] &b[S] &rФермер: &cПринеси хоть что-то'\r\n" +
                        "            - '[sound] ENTITY_VILLAGER_NO'\r\n" +
                       "      right_click_commands:\r\n" +
                       "         - '[console] clear %player_name% " + materalTextBox.Text + " " + countSellStackTextBox.Text + "'\r\n" +
                       "         - '[givemoney] " + priceSellStackTextBox.Text + "'\r\n" +
                       "         - '[message] &aВы продали &6" + countSellStackTextBox.Text + " " + name_itemTextBox.Text + " &aза " + priceSellStackTextBox.Text + "$'\r\n" +
                       "      shift_right_click_requirement:\r\n" +
                       "         requirements:\r\n" +
                       "            has_item:\r\n" +
                       "               type: has item\r\n" +
                       "               material: " + materalTextBox.Text + "\r\n" +
                       "               amount: " + countSellStackTextBox.Text + "\r\n" +
                       "         deny_commands:\r\n" +
                       "            - '[message] &b[S] &rФермер: &cПринеси хоть что-то'\r\n" +
                       "            - '[sound] ENTITY_VILLAGER_NO'\r\n" +
                       "      shift_right_click_commands:\r\n" +
                       "         - '[console] clear %player_name% " + materalTextBox.Text + " " + countSellStackTextBox.Text + "'\r\n" +
                       "         - '[givemoney] " + priceSellStackTextBox.Text + "'\r\n" +
                       "         - '[message] &aВы продали &6" + countSellStackTextBox.Text + " " + name_itemTextBox.Text + " &aза " + priceSellStackTextBox.Text + "$'";
            }
            else if (countSellOneTextBox.Text != "" && countSellStackTextBox.Text != "")
            {
                textBox10.Text +=
                       "      right_click_requirement:\r\n" +
                       "         requirements:\r\n" +
                       "            has_item:\r\n" +
                       "               type: has item\r\n" +
                       "               material: " + materalTextBox.Text + "\r\n" +
                       "               amount: " + countSellOneTextBox.Text + "\r\n" +
                       "         deny_commands:\r\n" +
                       "            - '[message] &b[S] &rФермер: &cПринеси хоть что-то'\r\n" +
                       "            - '[sound] ENTITY_VILLAGER_NO'\r\n" +
                       "      right_click_commands:\r\n" +
                       "         - '[console] clear %player_name% " + materalTextBox.Text + " " + countSellOneTextBox.Text + "'\r\n" +
                       "         - '[givemoney] " + priceSellOneTextBox.Text + "'\r\n" +
                       "         - '[message] &aВы продали &6" + countSellOneTextBox.Text + " " + name_itemTextBox.Text + " & aза " + priceSellOneTextBox.Text + "$'\r\n" +
                       "      shift_right_click_requirement:\r\n" +
                       "         requirements:\r\n" +
                       "            has_item:\r\n" +
                       "               type: has item\r\n" +
                       "               material: " + materalTextBox.Text + "\r\n" +
                       "               amount: " + countSellStackTextBox.Text + "\r\n" +
                       "         deny_commands:\r\n" +
                       "            - '[message] &b[S] &rФермер: &cПринеси хоть что-то'\r\n" +
                       "            - '[sound] ENTITY_VILLAGER_NO'\r\n" +
                       "      shift_right_click_commands:\r\n" +
                       "         - '[console] clear %player_name% " + materalTextBox.Text + " " + countSellStackTextBox.Text + "'\r\n" +
                       "         - '[givemoney] " + priceSellStackTextBox.Text + "'\r\n" +
                       "         - '[message] &aВы продали &6" + countSellStackTextBox.Text + " " + name_itemTextBox.Text + " &aза " + priceSellStackTextBox.Text + "$'";
            };
            Clipboard.SetText(textBox10.Text);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (priceBuyOneTextBox.Text != "") priceBuyStackTextBox.Text = Convert.ToString((Convert.ToInt32(countBuyStackTextBox.Text) / Convert.ToInt32(countBuyOneTextBox.Text)) * Convert.ToInt32(priceBuyOneTextBox.Text));
            if (priceSellOneTextBox.Text != "") priceSellStackTextBox.Text = Convert.ToString((Convert.ToInt32(countSellStackTextBox.Text) / Convert.ToInt32(countSellOneTextBox.Text)) * Convert.ToInt32(priceSellOneTextBox.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox10.Text = "\r\n" +
                "   'head" + slotTextBox_Head.Text + "':\r\n" +
                "      material: 'basehead-" + valueHeadTextBox.Text + "'\r\n" +
                "      slot: " + slotTextBox_Head.Text + "\r\n" +
                "      display_name: \"&7\"\r\n" +
                "      lore:\r\n" +
                "         - '&7&8ЛКМ&a Купить " + name_headTextBox.Text + " &7- &e[" + priceBuyHeadTextBox.Text + "$]'\r\n" +
                "         - '&7       лкм купить 1 " + name_headTextBox.Text + " за " + priceBuyHeadTextBox.Text + "$'\r\n" +
                "         - ' '\r\n" +
                "      left_click_requirement:\r\n" +
                "         requirements:\r\n" +
                "            has_money:\r\n" + 
                "               type: has money\r\n" +
                "               amount: " + priceBuyHeadTextBox.Text + "\r\n" +
                "         deny_commands:\r\n" +
                "            - '[message] &b[S] &rФермер: &cЯ не для бедных старался'\r\n" +
                "            - '[sound] ENTITY_VILLAGER_NO'\r\n" +
                "      left_click_commands:\r\n" +
                "         - '[console] minecraft:give %player_name% minecraft:player_head{display:{Name:\"{\\\"text\\\":\\\"" + name_headTextBox.Text +"\\\"}\"},SkullOwner:{Id:[I;797692767,214648518,-2094961131,-1410769773],Properties:{textures:[{Value:\"" + valueHeadTextBox.Text + "\"}]}}} 1'\r\n" +
                "         - '[takemoney] " + priceBuyHeadTextBox.Text + "'\r\n" +
                "      shift_left_click_requirement:\r\n" +
                "         requirements:\r\n" +
                "            has_money:\r\n" +
                "               type: has money\r\n" +
                "               amount: " + priceBuyHeadTextBox.Text + "\r\n" +
                "         deny_commands:\r\n" +
                "            - '[message] &b[S] &rФермер: &cЯ не для бедных старался'\r\n" +
                "            - '[sound] ENTITY_VILLAGER_NO'\r\n" +
                "      shift_left_click_commands:\r\n" +
                "         - '[console] minecraft:give %player_name% minecraft:player_head{display:{Name:\"{\\\"text\\\":\\\"" + name_headTextBox.Text + "\\\"}\"},SkullOwner:{Id:[I;797692767,214648518,-2094961131,-1410769773],Properties:{textures:[{Value:\"" + valueHeadTextBox.Text + "\"}]}}} 1'\r\n" +
                "         - '[takemoney] " + priceBuyHeadTextBox.Text + "'\r\n";
            Clipboard.SetText(textBox10.Text);
        }
    }
}
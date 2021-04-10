//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /home/daria/develop/uni/clojure-compiler/lexer/lexer/Grammar/Clojure.g4 by ANTLR 4.9.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.1")]
[System.CLSCompliant(false)]
public partial class ClojureLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, STRING=21, FLOAT=22, HEX=23, BIN=24, LONG=25, 
		BIGN=26, CHAR_U=27, CHAR_NAMED=28, CHAR_ANY=29, NIL=30, BOOLEAN=31, SYMBOL=32, 
		NS_SYMBOL=33, PARAM_NAME=34, TRASH=35;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "T__19", "STRING", "FLOAT", "FLOAT_TAIL", "FLOAT_DECIMAL", 
		"FLOAT_EXP", "HEXD", "HEX", "BIN", "LONG", "BIGN", "CHAR_U", "CHAR_NAMED", 
		"CHAR_ANY", "NIL", "BOOLEAN", "SYMBOL", "NS_SYMBOL", "PARAM_NAME", "NAME", 
		"SYMBOL_HEAD", "SYMBOL_REST", "WS", "COMMENT", "TRASH"
	};


	public ClojureLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public ClojureLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'('", "')'", "'['", "']'", "'{'", "'}'", "'#{'", "'''", "'`'", 
		"'~'", "'~@'", "'^'", "'@'", "'#'", "'#('", "'#^'", "'#''", "'#+'", "'#_'", 
		"':'", null, null, null, null, null, null, null, null, null, "'nil'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, "STRING", "FLOAT", 
		"HEX", "BIN", "LONG", "BIGN", "CHAR_U", "CHAR_NAMED", "CHAR_ANY", "NIL", 
		"BOOLEAN", "SYMBOL", "NS_SYMBOL", "PARAM_NAME", "TRASH"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Clojure.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static ClojureLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '%', '\x168', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x4', '\x19', '\t', '\x19', '\x4', '\x1A', '\t', '\x1A', '\x4', 
		'\x1B', '\t', '\x1B', '\x4', '\x1C', '\t', '\x1C', '\x4', '\x1D', '\t', 
		'\x1D', '\x4', '\x1E', '\t', '\x1E', '\x4', '\x1F', '\t', '\x1F', '\x4', 
		' ', '\t', ' ', '\x4', '!', '\t', '!', '\x4', '\"', '\t', '\"', '\x4', 
		'#', '\t', '#', '\x4', '$', '\t', '$', '\x4', '%', '\t', '%', '\x4', '&', 
		'\t', '&', '\x4', '\'', '\t', '\'', '\x4', '(', '\t', '(', '\x4', ')', 
		'\t', ')', '\x4', '*', '\t', '*', '\x4', '+', '\t', '+', '\x4', ',', '\t', 
		',', '\x4', '-', '\t', '-', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', '\x5', '\x3', '\x5', 
		'\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', 
		'\b', '\x3', '\b', '\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', 
		'\x3', '\v', '\x3', '\v', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', 
		'\r', '\x3', '\r', '\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x3', '\xF', 
		'\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x11', '\x3', '\x11', 
		'\x3', '\x11', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x13', 
		'\x3', '\x13', '\x3', '\x13', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', 
		'\x3', '\x15', '\x3', '\x15', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', 
		'\x3', '\x16', '\a', '\x16', '\x8F', '\n', '\x16', '\f', '\x16', '\xE', 
		'\x16', '\x92', '\v', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x17', 
		'\x5', '\x17', '\x97', '\n', '\x17', '\x3', '\x17', '\x6', '\x17', '\x9A', 
		'\n', '\x17', '\r', '\x17', '\xE', '\x17', '\x9B', '\x3', '\x17', '\x3', 
		'\x17', '\x5', '\x17', '\xA0', '\n', '\x17', '\x3', '\x17', '\x3', '\x17', 
		'\x3', '\x17', '\x3', '\x17', '\x3', '\x17', '\x3', '\x17', '\x3', '\x17', 
		'\x3', '\x17', '\x3', '\x17', '\x5', '\x17', '\xAB', '\n', '\x17', '\x3', 
		'\x17', '\x3', '\x17', '\x3', '\x17', '\x5', '\x17', '\xB0', '\n', '\x17', 
		'\x3', '\x18', '\x3', '\x18', '\x3', '\x18', '\x3', '\x18', '\x3', '\x18', 
		'\x5', '\x18', '\xB7', '\n', '\x18', '\x3', '\x19', '\x3', '\x19', '\x6', 
		'\x19', '\xBB', '\n', '\x19', '\r', '\x19', '\xE', '\x19', '\xBC', '\x3', 
		'\x1A', '\x3', '\x1A', '\x5', '\x1A', '\xC1', '\n', '\x1A', '\x3', '\x1A', 
		'\x6', '\x1A', '\xC4', '\n', '\x1A', '\r', '\x1A', '\xE', '\x1A', '\xC5', 
		'\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1C', 
		'\x6', '\x1C', '\xCD', '\n', '\x1C', '\r', '\x1C', '\xE', '\x1C', '\xCE', 
		'\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x6', '\x1D', '\xD4', '\n', 
		'\x1D', '\r', '\x1D', '\xE', '\x1D', '\xD5', '\x3', '\x1E', '\x5', '\x1E', 
		'\xD9', '\n', '\x1E', '\x3', '\x1E', '\x6', '\x1E', '\xDC', '\n', '\x1E', 
		'\r', '\x1E', '\xE', '\x1E', '\xDD', '\x3', '\x1E', '\x5', '\x1E', '\xE1', 
		'\n', '\x1E', '\x3', '\x1F', '\x5', '\x1F', '\xE4', '\n', '\x1F', '\x3', 
		'\x1F', '\x6', '\x1F', '\xE7', '\n', '\x1F', '\r', '\x1F', '\xE', '\x1F', 
		'\xE8', '\x3', '\x1F', '\x3', '\x1F', '\x3', ' ', '\x3', ' ', '\x3', ' ', 
		'\x3', ' ', '\x3', ' ', '\x3', ' ', '\x3', ' ', '\x3', '!', '\x3', '!', 
		'\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', 
		'\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', 
		'\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', 
		'\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', 
		'\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', 
		'\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', 
		'\x3', '!', '\x5', '!', '\x11B', '\n', '!', '\x3', '\"', '\x3', '\"', 
		'\x3', '\"', '\x3', '#', '\x3', '#', '\x3', '#', '\x3', '#', '\x3', '$', 
		'\x3', '$', '\x3', '$', '\x3', '$', '\x3', '$', '\x3', '$', '\x3', '$', 
		'\x3', '$', '\x3', '$', '\x5', '$', '\x12D', '\n', '$', '\x3', '%', '\x3', 
		'%', '\x5', '%', '\x131', '\n', '%', '\x3', '&', '\x3', '&', '\x3', '&', 
		'\x3', '&', '\x3', '\'', '\x3', '\'', '\x3', '\'', '\a', '\'', '\x13A', 
		'\n', '\'', '\f', '\'', '\xE', '\'', '\x13D', '\v', '\'', '\x3', '\'', 
		'\x5', '\'', '\x140', '\n', '\'', '\x3', '(', '\x3', '(', '\a', '(', '\x144', 
		'\n', '(', '\f', '(', '\xE', '(', '\x147', '\v', '(', '\x3', '(', '\x3', 
		'(', '\x6', '(', '\x14B', '\n', '(', '\r', '(', '\xE', '(', '\x14C', '\a', 
		'(', '\x14F', '\n', '(', '\f', '(', '\xE', '(', '\x152', '\v', '(', '\x3', 
		')', '\x3', ')', '\x3', '*', '\x3', '*', '\x5', '*', '\x158', '\n', '*', 
		'\x3', '+', '\x3', '+', '\x3', ',', '\x3', ',', '\a', ',', '\x15E', '\n', 
		',', '\f', ',', '\xE', ',', '\x161', '\v', ',', '\x3', '-', '\x3', '-', 
		'\x5', '-', '\x165', '\n', '-', '\x3', '-', '\x3', '-', '\x2', '\x2', 
		'.', '\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', 
		'\r', '\b', '\xF', '\t', '\x11', '\n', '\x13', '\v', '\x15', '\f', '\x17', 
		'\r', '\x19', '\xE', '\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x11', '!', 
		'\x12', '#', '\x13', '%', '\x14', '\'', '\x15', ')', '\x16', '+', '\x17', 
		'-', '\x18', '/', '\x2', '\x31', '\x2', '\x33', '\x2', '\x35', '\x2', 
		'\x37', '\x19', '\x39', '\x1A', ';', '\x1B', '=', '\x1C', '?', '\x1D', 
		'\x41', '\x1E', '\x43', '\x1F', '\x45', ' ', 'G', '!', 'I', '\"', 'K', 
		'#', 'M', '$', 'O', '\x2', 'Q', '\x2', 'S', '\x2', 'U', '\x2', 'W', '\x2', 
		'Y', '%', '\x3', '\x2', '\x10', '\x3', '\x2', '$', '$', '\x3', '\x2', 
		'\x32', ';', '\x4', '\x2', 'G', 'G', 'g', 'g', '\x5', '\x2', '\x32', ';', 
		'\x43', 'H', '\x63', 'h', '\x4', '\x2', 'Z', 'Z', 'z', 'z', '\x4', '\x2', 
		'\x44', '\x44', '\x64', '\x64', '\x3', '\x2', '\x32', '\x33', '\x4', '\x2', 
		'N', 'N', 'n', 'n', '\x4', '\x2', 'P', 'P', 'p', 'p', '\x5', '\x2', '\x32', 
		';', '\x46', 'H', '\x66', 'h', '\x10', '\x2', '\v', '\f', '\xF', '\xF', 
		'\"', '\"', '$', '%', '\'', '\'', ')', '+', '.', '.', '\x31', '<', '\x42', 
		'\x42', ']', ']', '_', '`', '\x62', '\x62', '}', '}', '\x7F', '\x80', 
		'\x4', '\x2', '\x30', '\x30', '\x32', ';', '\x6', '\x2', '\v', '\f', '\xF', 
		'\xF', '\"', '\"', '.', '.', '\x4', '\x2', '\f', '\f', '\xF', '\xF', '\x2', 
		'\x182', '\x2', '\x3', '\x3', '\x2', '\x2', '\x2', '\x2', '\x5', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', '\x2', '\x2', '\x17', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x19', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', '\x2', '\x2', '\x2', '!', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '#', '\x3', '\x2', '\x2', '\x2', '\x2', '%', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\'', '\x3', '\x2', '\x2', '\x2', '\x2', 
		')', '\x3', '\x2', '\x2', '\x2', '\x2', '+', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '-', '\x3', '\x2', '\x2', '\x2', '\x2', '\x37', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x39', '\x3', '\x2', '\x2', '\x2', '\x2', ';', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '=', '\x3', '\x2', '\x2', '\x2', '\x2', '?', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x41', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x43', '\x3', '\x2', '\x2', '\x2', '\x2', '\x45', '\x3', '\x2', '\x2', 
		'\x2', '\x2', 'G', '\x3', '\x2', '\x2', '\x2', '\x2', 'I', '\x3', '\x2', 
		'\x2', '\x2', '\x2', 'K', '\x3', '\x2', '\x2', '\x2', '\x2', 'M', '\x3', 
		'\x2', '\x2', '\x2', '\x2', 'Y', '\x3', '\x2', '\x2', '\x2', '\x3', '[', 
		'\x3', '\x2', '\x2', '\x2', '\x5', ']', '\x3', '\x2', '\x2', '\x2', '\a', 
		'_', '\x3', '\x2', '\x2', '\x2', '\t', '\x61', '\x3', '\x2', '\x2', '\x2', 
		'\v', '\x63', '\x3', '\x2', '\x2', '\x2', '\r', '\x65', '\x3', '\x2', 
		'\x2', '\x2', '\xF', 'g', '\x3', '\x2', '\x2', '\x2', '\x11', 'j', '\x3', 
		'\x2', '\x2', '\x2', '\x13', 'l', '\x3', '\x2', '\x2', '\x2', '\x15', 
		'n', '\x3', '\x2', '\x2', '\x2', '\x17', 'p', '\x3', '\x2', '\x2', '\x2', 
		'\x19', 's', '\x3', '\x2', '\x2', '\x2', '\x1B', 'u', '\x3', '\x2', '\x2', 
		'\x2', '\x1D', 'w', '\x3', '\x2', '\x2', '\x2', '\x1F', 'y', '\x3', '\x2', 
		'\x2', '\x2', '!', '|', '\x3', '\x2', '\x2', '\x2', '#', '\x7F', '\x3', 
		'\x2', '\x2', '\x2', '%', '\x82', '\x3', '\x2', '\x2', '\x2', '\'', '\x85', 
		'\x3', '\x2', '\x2', '\x2', ')', '\x88', '\x3', '\x2', '\x2', '\x2', '+', 
		'\x8A', '\x3', '\x2', '\x2', '\x2', '-', '\xAF', '\x3', '\x2', '\x2', 
		'\x2', '/', '\xB6', '\x3', '\x2', '\x2', '\x2', '\x31', '\xB8', '\x3', 
		'\x2', '\x2', '\x2', '\x33', '\xBE', '\x3', '\x2', '\x2', '\x2', '\x35', 
		'\xC7', '\x3', '\x2', '\x2', '\x2', '\x37', '\xC9', '\x3', '\x2', '\x2', 
		'\x2', '\x39', '\xD0', '\x3', '\x2', '\x2', '\x2', ';', '\xD8', '\x3', 
		'\x2', '\x2', '\x2', '=', '\xE3', '\x3', '\x2', '\x2', '\x2', '?', '\xEC', 
		'\x3', '\x2', '\x2', '\x2', '\x41', '\xF3', '\x3', '\x2', '\x2', '\x2', 
		'\x43', '\x11C', '\x3', '\x2', '\x2', '\x2', '\x45', '\x11F', '\x3', '\x2', 
		'\x2', '\x2', 'G', '\x12C', '\x3', '\x2', '\x2', '\x2', 'I', '\x130', 
		'\x3', '\x2', '\x2', '\x2', 'K', '\x132', '\x3', '\x2', '\x2', '\x2', 
		'M', '\x136', '\x3', '\x2', '\x2', '\x2', 'O', '\x141', '\x3', '\x2', 
		'\x2', '\x2', 'Q', '\x153', '\x3', '\x2', '\x2', '\x2', 'S', '\x157', 
		'\x3', '\x2', '\x2', '\x2', 'U', '\x159', '\x3', '\x2', '\x2', '\x2', 
		'W', '\x15B', '\x3', '\x2', '\x2', '\x2', 'Y', '\x164', '\x3', '\x2', 
		'\x2', '\x2', '[', '\\', '\a', '*', '\x2', '\x2', '\\', '\x4', '\x3', 
		'\x2', '\x2', '\x2', ']', '^', '\a', '+', '\x2', '\x2', '^', '\x6', '\x3', 
		'\x2', '\x2', '\x2', '_', '`', '\a', ']', '\x2', '\x2', '`', '\b', '\x3', 
		'\x2', '\x2', '\x2', '\x61', '\x62', '\a', '_', '\x2', '\x2', '\x62', 
		'\n', '\x3', '\x2', '\x2', '\x2', '\x63', '\x64', '\a', '}', '\x2', '\x2', 
		'\x64', '\f', '\x3', '\x2', '\x2', '\x2', '\x65', '\x66', '\a', '\x7F', 
		'\x2', '\x2', '\x66', '\xE', '\x3', '\x2', '\x2', '\x2', 'g', 'h', '\a', 
		'%', '\x2', '\x2', 'h', 'i', '\a', '}', '\x2', '\x2', 'i', '\x10', '\x3', 
		'\x2', '\x2', '\x2', 'j', 'k', '\a', ')', '\x2', '\x2', 'k', '\x12', '\x3', 
		'\x2', '\x2', '\x2', 'l', 'm', '\a', '\x62', '\x2', '\x2', 'm', '\x14', 
		'\x3', '\x2', '\x2', '\x2', 'n', 'o', '\a', '\x80', '\x2', '\x2', 'o', 
		'\x16', '\x3', '\x2', '\x2', '\x2', 'p', 'q', '\a', '\x80', '\x2', '\x2', 
		'q', 'r', '\a', '\x42', '\x2', '\x2', 'r', '\x18', '\x3', '\x2', '\x2', 
		'\x2', 's', 't', '\a', '`', '\x2', '\x2', 't', '\x1A', '\x3', '\x2', '\x2', 
		'\x2', 'u', 'v', '\a', '\x42', '\x2', '\x2', 'v', '\x1C', '\x3', '\x2', 
		'\x2', '\x2', 'w', 'x', '\a', '%', '\x2', '\x2', 'x', '\x1E', '\x3', '\x2', 
		'\x2', '\x2', 'y', 'z', '\a', '%', '\x2', '\x2', 'z', '{', '\a', '*', 
		'\x2', '\x2', '{', ' ', '\x3', '\x2', '\x2', '\x2', '|', '}', '\a', '%', 
		'\x2', '\x2', '}', '~', '\a', '`', '\x2', '\x2', '~', '\"', '\x3', '\x2', 
		'\x2', '\x2', '\x7F', '\x80', '\a', '%', '\x2', '\x2', '\x80', '\x81', 
		'\a', ')', '\x2', '\x2', '\x81', '$', '\x3', '\x2', '\x2', '\x2', '\x82', 
		'\x83', '\a', '%', '\x2', '\x2', '\x83', '\x84', '\a', '-', '\x2', '\x2', 
		'\x84', '&', '\x3', '\x2', '\x2', '\x2', '\x85', '\x86', '\a', '%', '\x2', 
		'\x2', '\x86', '\x87', '\a', '\x61', '\x2', '\x2', '\x87', '(', '\x3', 
		'\x2', '\x2', '\x2', '\x88', '\x89', '\a', '<', '\x2', '\x2', '\x89', 
		'*', '\x3', '\x2', '\x2', '\x2', '\x8A', '\x90', '\a', '$', '\x2', '\x2', 
		'\x8B', '\x8F', '\n', '\x2', '\x2', '\x2', '\x8C', '\x8D', '\a', '^', 
		'\x2', '\x2', '\x8D', '\x8F', '\a', '$', '\x2', '\x2', '\x8E', '\x8B', 
		'\x3', '\x2', '\x2', '\x2', '\x8E', '\x8C', '\x3', '\x2', '\x2', '\x2', 
		'\x8F', '\x92', '\x3', '\x2', '\x2', '\x2', '\x90', '\x8E', '\x3', '\x2', 
		'\x2', '\x2', '\x90', '\x91', '\x3', '\x2', '\x2', '\x2', '\x91', '\x93', 
		'\x3', '\x2', '\x2', '\x2', '\x92', '\x90', '\x3', '\x2', '\x2', '\x2', 
		'\x93', '\x94', '\a', '$', '\x2', '\x2', '\x94', ',', '\x3', '\x2', '\x2', 
		'\x2', '\x95', '\x97', '\a', '/', '\x2', '\x2', '\x96', '\x95', '\x3', 
		'\x2', '\x2', '\x2', '\x96', '\x97', '\x3', '\x2', '\x2', '\x2', '\x97', 
		'\x99', '\x3', '\x2', '\x2', '\x2', '\x98', '\x9A', '\t', '\x3', '\x2', 
		'\x2', '\x99', '\x98', '\x3', '\x2', '\x2', '\x2', '\x9A', '\x9B', '\x3', 
		'\x2', '\x2', '\x2', '\x9B', '\x99', '\x3', '\x2', '\x2', '\x2', '\x9B', 
		'\x9C', '\x3', '\x2', '\x2', '\x2', '\x9C', '\x9D', '\x3', '\x2', '\x2', 
		'\x2', '\x9D', '\xB0', '\x5', '/', '\x18', '\x2', '\x9E', '\xA0', '\a', 
		'/', '\x2', '\x2', '\x9F', '\x9E', '\x3', '\x2', '\x2', '\x2', '\x9F', 
		'\xA0', '\x3', '\x2', '\x2', '\x2', '\xA0', '\xA1', '\x3', '\x2', '\x2', 
		'\x2', '\xA1', '\xA2', '\a', 'K', '\x2', '\x2', '\xA2', '\xA3', '\a', 
		'p', '\x2', '\x2', '\xA3', '\xA4', '\a', 'h', '\x2', '\x2', '\xA4', '\xA5', 
		'\a', 'k', '\x2', '\x2', '\xA5', '\xA6', '\a', 'p', '\x2', '\x2', '\xA6', 
		'\xA7', '\a', 'k', '\x2', '\x2', '\xA7', '\xA8', '\a', 'v', '\x2', '\x2', 
		'\xA8', '\xB0', '\a', '{', '\x2', '\x2', '\xA9', '\xAB', '\a', '/', '\x2', 
		'\x2', '\xAA', '\xA9', '\x3', '\x2', '\x2', '\x2', '\xAA', '\xAB', '\x3', 
		'\x2', '\x2', '\x2', '\xAB', '\xAC', '\x3', '\x2', '\x2', '\x2', '\xAC', 
		'\xAD', '\a', 'P', '\x2', '\x2', '\xAD', '\xAE', '\a', '\x63', '\x2', 
		'\x2', '\xAE', '\xB0', '\a', 'P', '\x2', '\x2', '\xAF', '\x96', '\x3', 
		'\x2', '\x2', '\x2', '\xAF', '\x9F', '\x3', '\x2', '\x2', '\x2', '\xAF', 
		'\xAA', '\x3', '\x2', '\x2', '\x2', '\xB0', '.', '\x3', '\x2', '\x2', 
		'\x2', '\xB1', '\xB2', '\x5', '\x31', '\x19', '\x2', '\xB2', '\xB3', '\x5', 
		'\x33', '\x1A', '\x2', '\xB3', '\xB7', '\x3', '\x2', '\x2', '\x2', '\xB4', 
		'\xB7', '\x5', '\x31', '\x19', '\x2', '\xB5', '\xB7', '\x5', '\x33', '\x1A', 
		'\x2', '\xB6', '\xB1', '\x3', '\x2', '\x2', '\x2', '\xB6', '\xB4', '\x3', 
		'\x2', '\x2', '\x2', '\xB6', '\xB5', '\x3', '\x2', '\x2', '\x2', '\xB7', 
		'\x30', '\x3', '\x2', '\x2', '\x2', '\xB8', '\xBA', '\a', '\x30', '\x2', 
		'\x2', '\xB9', '\xBB', '\t', '\x3', '\x2', '\x2', '\xBA', '\xB9', '\x3', 
		'\x2', '\x2', '\x2', '\xBB', '\xBC', '\x3', '\x2', '\x2', '\x2', '\xBC', 
		'\xBA', '\x3', '\x2', '\x2', '\x2', '\xBC', '\xBD', '\x3', '\x2', '\x2', 
		'\x2', '\xBD', '\x32', '\x3', '\x2', '\x2', '\x2', '\xBE', '\xC0', '\t', 
		'\x4', '\x2', '\x2', '\xBF', '\xC1', '\a', '/', '\x2', '\x2', '\xC0', 
		'\xBF', '\x3', '\x2', '\x2', '\x2', '\xC0', '\xC1', '\x3', '\x2', '\x2', 
		'\x2', '\xC1', '\xC3', '\x3', '\x2', '\x2', '\x2', '\xC2', '\xC4', '\t', 
		'\x3', '\x2', '\x2', '\xC3', '\xC2', '\x3', '\x2', '\x2', '\x2', '\xC4', 
		'\xC5', '\x3', '\x2', '\x2', '\x2', '\xC5', '\xC3', '\x3', '\x2', '\x2', 
		'\x2', '\xC5', '\xC6', '\x3', '\x2', '\x2', '\x2', '\xC6', '\x34', '\x3', 
		'\x2', '\x2', '\x2', '\xC7', '\xC8', '\t', '\x5', '\x2', '\x2', '\xC8', 
		'\x36', '\x3', '\x2', '\x2', '\x2', '\xC9', '\xCA', '\a', '\x32', '\x2', 
		'\x2', '\xCA', '\xCC', '\t', '\x6', '\x2', '\x2', '\xCB', '\xCD', '\x5', 
		'\x35', '\x1B', '\x2', '\xCC', '\xCB', '\x3', '\x2', '\x2', '\x2', '\xCD', 
		'\xCE', '\x3', '\x2', '\x2', '\x2', '\xCE', '\xCC', '\x3', '\x2', '\x2', 
		'\x2', '\xCE', '\xCF', '\x3', '\x2', '\x2', '\x2', '\xCF', '\x38', '\x3', 
		'\x2', '\x2', '\x2', '\xD0', '\xD1', '\a', '\x32', '\x2', '\x2', '\xD1', 
		'\xD3', '\t', '\a', '\x2', '\x2', '\xD2', '\xD4', '\t', '\b', '\x2', '\x2', 
		'\xD3', '\xD2', '\x3', '\x2', '\x2', '\x2', '\xD4', '\xD5', '\x3', '\x2', 
		'\x2', '\x2', '\xD5', '\xD3', '\x3', '\x2', '\x2', '\x2', '\xD5', '\xD6', 
		'\x3', '\x2', '\x2', '\x2', '\xD6', ':', '\x3', '\x2', '\x2', '\x2', '\xD7', 
		'\xD9', '\a', '/', '\x2', '\x2', '\xD8', '\xD7', '\x3', '\x2', '\x2', 
		'\x2', '\xD8', '\xD9', '\x3', '\x2', '\x2', '\x2', '\xD9', '\xDB', '\x3', 
		'\x2', '\x2', '\x2', '\xDA', '\xDC', '\t', '\x3', '\x2', '\x2', '\xDB', 
		'\xDA', '\x3', '\x2', '\x2', '\x2', '\xDC', '\xDD', '\x3', '\x2', '\x2', 
		'\x2', '\xDD', '\xDB', '\x3', '\x2', '\x2', '\x2', '\xDD', '\xDE', '\x3', 
		'\x2', '\x2', '\x2', '\xDE', '\xE0', '\x3', '\x2', '\x2', '\x2', '\xDF', 
		'\xE1', '\t', '\t', '\x2', '\x2', '\xE0', '\xDF', '\x3', '\x2', '\x2', 
		'\x2', '\xE0', '\xE1', '\x3', '\x2', '\x2', '\x2', '\xE1', '<', '\x3', 
		'\x2', '\x2', '\x2', '\xE2', '\xE4', '\a', '/', '\x2', '\x2', '\xE3', 
		'\xE2', '\x3', '\x2', '\x2', '\x2', '\xE3', '\xE4', '\x3', '\x2', '\x2', 
		'\x2', '\xE4', '\xE6', '\x3', '\x2', '\x2', '\x2', '\xE5', '\xE7', '\t', 
		'\x3', '\x2', '\x2', '\xE6', '\xE5', '\x3', '\x2', '\x2', '\x2', '\xE7', 
		'\xE8', '\x3', '\x2', '\x2', '\x2', '\xE8', '\xE6', '\x3', '\x2', '\x2', 
		'\x2', '\xE8', '\xE9', '\x3', '\x2', '\x2', '\x2', '\xE9', '\xEA', '\x3', 
		'\x2', '\x2', '\x2', '\xEA', '\xEB', '\t', '\n', '\x2', '\x2', '\xEB', 
		'>', '\x3', '\x2', '\x2', '\x2', '\xEC', '\xED', '\a', '^', '\x2', '\x2', 
		'\xED', '\xEE', '\a', 'w', '\x2', '\x2', '\xEE', '\xEF', '\t', '\v', '\x2', 
		'\x2', '\xEF', '\xF0', '\x5', '\x35', '\x1B', '\x2', '\xF0', '\xF1', '\x5', 
		'\x35', '\x1B', '\x2', '\xF1', '\xF2', '\x5', '\x35', '\x1B', '\x2', '\xF2', 
		'@', '\x3', '\x2', '\x2', '\x2', '\xF3', '\x11A', '\a', '^', '\x2', '\x2', 
		'\xF4', '\xF5', '\a', 'p', '\x2', '\x2', '\xF5', '\xF6', '\a', 'g', '\x2', 
		'\x2', '\xF6', '\xF7', '\a', 'y', '\x2', '\x2', '\xF7', '\xF8', '\a', 
		'n', '\x2', '\x2', '\xF8', '\xF9', '\a', 'k', '\x2', '\x2', '\xF9', '\xFA', 
		'\a', 'p', '\x2', '\x2', '\xFA', '\x11B', '\a', 'g', '\x2', '\x2', '\xFB', 
		'\xFC', '\a', 't', '\x2', '\x2', '\xFC', '\xFD', '\a', 'g', '\x2', '\x2', 
		'\xFD', '\xFE', '\a', 'v', '\x2', '\x2', '\xFE', '\xFF', '\a', 'w', '\x2', 
		'\x2', '\xFF', '\x100', '\a', 't', '\x2', '\x2', '\x100', '\x11B', '\a', 
		'p', '\x2', '\x2', '\x101', '\x102', '\a', 'u', '\x2', '\x2', '\x102', 
		'\x103', '\a', 'r', '\x2', '\x2', '\x103', '\x104', '\a', '\x63', '\x2', 
		'\x2', '\x104', '\x105', '\a', '\x65', '\x2', '\x2', '\x105', '\x11B', 
		'\a', 'g', '\x2', '\x2', '\x106', '\x107', '\a', 'v', '\x2', '\x2', '\x107', 
		'\x108', '\a', '\x63', '\x2', '\x2', '\x108', '\x11B', '\a', '\x64', '\x2', 
		'\x2', '\x109', '\x10A', '\a', 'h', '\x2', '\x2', '\x10A', '\x10B', '\a', 
		'q', '\x2', '\x2', '\x10B', '\x10C', '\a', 't', '\x2', '\x2', '\x10C', 
		'\x10D', '\a', 'o', '\x2', '\x2', '\x10D', '\x10E', '\a', 'h', '\x2', 
		'\x2', '\x10E', '\x10F', '\a', 'g', '\x2', '\x2', '\x10F', '\x110', '\a', 
		'g', '\x2', '\x2', '\x110', '\x11B', '\a', '\x66', '\x2', '\x2', '\x111', 
		'\x112', '\a', '\x64', '\x2', '\x2', '\x112', '\x113', '\a', '\x63', '\x2', 
		'\x2', '\x113', '\x114', '\a', '\x65', '\x2', '\x2', '\x114', '\x115', 
		'\a', 'm', '\x2', '\x2', '\x115', '\x116', '\a', 'u', '\x2', '\x2', '\x116', 
		'\x117', '\a', 'r', '\x2', '\x2', '\x117', '\x118', '\a', '\x63', '\x2', 
		'\x2', '\x118', '\x119', '\a', '\x65', '\x2', '\x2', '\x119', '\x11B', 
		'\a', 'g', '\x2', '\x2', '\x11A', '\xF4', '\x3', '\x2', '\x2', '\x2', 
		'\x11A', '\xFB', '\x3', '\x2', '\x2', '\x2', '\x11A', '\x101', '\x3', 
		'\x2', '\x2', '\x2', '\x11A', '\x106', '\x3', '\x2', '\x2', '\x2', '\x11A', 
		'\x109', '\x3', '\x2', '\x2', '\x2', '\x11A', '\x111', '\x3', '\x2', '\x2', 
		'\x2', '\x11B', '\x42', '\x3', '\x2', '\x2', '\x2', '\x11C', '\x11D', 
		'\a', '^', '\x2', '\x2', '\x11D', '\x11E', '\v', '\x2', '\x2', '\x2', 
		'\x11E', '\x44', '\x3', '\x2', '\x2', '\x2', '\x11F', '\x120', '\a', 'p', 
		'\x2', '\x2', '\x120', '\x121', '\a', 'k', '\x2', '\x2', '\x121', '\x122', 
		'\a', 'n', '\x2', '\x2', '\x122', '\x46', '\x3', '\x2', '\x2', '\x2', 
		'\x123', '\x124', '\a', 'v', '\x2', '\x2', '\x124', '\x125', '\a', 't', 
		'\x2', '\x2', '\x125', '\x126', '\a', 'w', '\x2', '\x2', '\x126', '\x12D', 
		'\a', 'g', '\x2', '\x2', '\x127', '\x128', '\a', 'h', '\x2', '\x2', '\x128', 
		'\x129', '\a', '\x63', '\x2', '\x2', '\x129', '\x12A', '\a', 'n', '\x2', 
		'\x2', '\x12A', '\x12B', '\a', 'u', '\x2', '\x2', '\x12B', '\x12D', '\a', 
		'g', '\x2', '\x2', '\x12C', '\x123', '\x3', '\x2', '\x2', '\x2', '\x12C', 
		'\x127', '\x3', '\x2', '\x2', '\x2', '\x12D', 'H', '\x3', '\x2', '\x2', 
		'\x2', '\x12E', '\x131', '\x4', '\x30', '\x31', '\x2', '\x12F', '\x131', 
		'\x5', 'O', '(', '\x2', '\x130', '\x12E', '\x3', '\x2', '\x2', '\x2', 
		'\x130', '\x12F', '\x3', '\x2', '\x2', '\x2', '\x131', 'J', '\x3', '\x2', 
		'\x2', '\x2', '\x132', '\x133', '\x5', 'O', '(', '\x2', '\x133', '\x134', 
		'\a', '\x31', '\x2', '\x2', '\x134', '\x135', '\x5', 'I', '%', '\x2', 
		'\x135', 'L', '\x3', '\x2', '\x2', '\x2', '\x136', '\x13F', '\a', '\'', 
		'\x2', '\x2', '\x137', '\x13B', '\x4', '\x33', ';', '\x2', '\x138', '\x13A', 
		'\x4', '\x32', ';', '\x2', '\x139', '\x138', '\x3', '\x2', '\x2', '\x2', 
		'\x13A', '\x13D', '\x3', '\x2', '\x2', '\x2', '\x13B', '\x139', '\x3', 
		'\x2', '\x2', '\x2', '\x13B', '\x13C', '\x3', '\x2', '\x2', '\x2', '\x13C', 
		'\x140', '\x3', '\x2', '\x2', '\x2', '\x13D', '\x13B', '\x3', '\x2', '\x2', 
		'\x2', '\x13E', '\x140', '\a', '(', '\x2', '\x2', '\x13F', '\x137', '\x3', 
		'\x2', '\x2', '\x2', '\x13F', '\x13E', '\x3', '\x2', '\x2', '\x2', '\x13F', 
		'\x140', '\x3', '\x2', '\x2', '\x2', '\x140', 'N', '\x3', '\x2', '\x2', 
		'\x2', '\x141', '\x145', '\x5', 'Q', ')', '\x2', '\x142', '\x144', '\x5', 
		'S', '*', '\x2', '\x143', '\x142', '\x3', '\x2', '\x2', '\x2', '\x144', 
		'\x147', '\x3', '\x2', '\x2', '\x2', '\x145', '\x143', '\x3', '\x2', '\x2', 
		'\x2', '\x145', '\x146', '\x3', '\x2', '\x2', '\x2', '\x146', '\x150', 
		'\x3', '\x2', '\x2', '\x2', '\x147', '\x145', '\x3', '\x2', '\x2', '\x2', 
		'\x148', '\x14A', '\a', '<', '\x2', '\x2', '\x149', '\x14B', '\x5', 'S', 
		'*', '\x2', '\x14A', '\x149', '\x3', '\x2', '\x2', '\x2', '\x14B', '\x14C', 
		'\x3', '\x2', '\x2', '\x2', '\x14C', '\x14A', '\x3', '\x2', '\x2', '\x2', 
		'\x14C', '\x14D', '\x3', '\x2', '\x2', '\x2', '\x14D', '\x14F', '\x3', 
		'\x2', '\x2', '\x2', '\x14E', '\x148', '\x3', '\x2', '\x2', '\x2', '\x14F', 
		'\x152', '\x3', '\x2', '\x2', '\x2', '\x150', '\x14E', '\x3', '\x2', '\x2', 
		'\x2', '\x150', '\x151', '\x3', '\x2', '\x2', '\x2', '\x151', 'P', '\x3', 
		'\x2', '\x2', '\x2', '\x152', '\x150', '\x3', '\x2', '\x2', '\x2', '\x153', 
		'\x154', '\n', '\f', '\x2', '\x2', '\x154', 'R', '\x3', '\x2', '\x2', 
		'\x2', '\x155', '\x158', '\x5', 'Q', ')', '\x2', '\x156', '\x158', '\t', 
		'\r', '\x2', '\x2', '\x157', '\x155', '\x3', '\x2', '\x2', '\x2', '\x157', 
		'\x156', '\x3', '\x2', '\x2', '\x2', '\x158', 'T', '\x3', '\x2', '\x2', 
		'\x2', '\x159', '\x15A', '\t', '\xE', '\x2', '\x2', '\x15A', 'V', '\x3', 
		'\x2', '\x2', '\x2', '\x15B', '\x15F', '\a', '=', '\x2', '\x2', '\x15C', 
		'\x15E', '\n', '\xF', '\x2', '\x2', '\x15D', '\x15C', '\x3', '\x2', '\x2', 
		'\x2', '\x15E', '\x161', '\x3', '\x2', '\x2', '\x2', '\x15F', '\x15D', 
		'\x3', '\x2', '\x2', '\x2', '\x15F', '\x160', '\x3', '\x2', '\x2', '\x2', 
		'\x160', 'X', '\x3', '\x2', '\x2', '\x2', '\x161', '\x15F', '\x3', '\x2', 
		'\x2', '\x2', '\x162', '\x165', '\x5', 'U', '+', '\x2', '\x163', '\x165', 
		'\x5', 'W', ',', '\x2', '\x164', '\x162', '\x3', '\x2', '\x2', '\x2', 
		'\x164', '\x163', '\x3', '\x2', '\x2', '\x2', '\x165', '\x166', '\x3', 
		'\x2', '\x2', '\x2', '\x166', '\x167', '\b', '-', '\x2', '\x2', '\x167', 
		'Z', '\x3', '\x2', '\x2', '\x2', ' ', '\x2', '\x8E', '\x90', '\x96', '\x9B', 
		'\x9F', '\xAA', '\xAF', '\xB6', '\xBC', '\xC0', '\xC5', '\xCE', '\xD5', 
		'\xD8', '\xDD', '\xE0', '\xE3', '\xE8', '\x11A', '\x12C', '\x130', '\x13B', 
		'\x13F', '\x145', '\x14C', '\x150', '\x157', '\x15F', '\x164', '\x3', 
		'\x2', '\x3', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}

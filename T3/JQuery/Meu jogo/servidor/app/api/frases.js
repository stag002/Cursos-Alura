var api = {};

var frases = [
	{_id: 0, texto:'Não consegue né', tempo: 4 },
	{_id: 1, texto:'Messi é melhor que Maradona',tempo: 5 },
	{_id: 2, texto:'Bom dia, cidadão', tempo: 3 },
	{_id: 3, texto:'Eu penso, logo existo', tempo: 4},
	{_id: 4, texto:'Melhor Jair acostumando', tempo: 3 },
	{_id: 5, texto:'É só parar pra pensar um pouco', tempo: 5 },
	{_id: 6, texto:'Perfeito!', tempo: 2 },
	{_id: 7, texto:'Hi, Big Monsters', tempo: 4 },
	{_id: 8, texto:'Um mol', tempo: 2},
	{_id: 9, texto:'Agora é 13:01 professora!', tempo: 6},

	];

api.lista = function(req, res) {

	setTimeout(function(){
		if(req.query.id) return res.json(frases[req.query.id]);

		res.json(frases);
	},1500);

};

module.exports = api;

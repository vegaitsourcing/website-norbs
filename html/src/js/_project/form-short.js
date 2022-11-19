const formShort = {
	form: document.querySelector('.form-short__form'),

	init: function() {
		this.form.addEventListener('submit', (e) => {
			e.preventDefault();
			const clicked = e.target;
			const firstName = clicked.querySelector('#name').value;
			const lastName = clicked.querySelector('#prename').value;
			const telephone = clicked.querySelector('#telephone').value;
			const email = clicked.querySelector('#email').value;
			const story = clicked.querySelector('.form-short__textarea').value;
			const data = {
				firstName,
				lastName,
				telephone,
				email,
				story
			};
			$.ajax({
				type: 'POST',
				contentType: 'application/json',
				url: '/forms/sharestory',
				data: JSON.stringify(data),
				dataType: 'json',
				success: this.onSuccess(),
			});

			return false;
		});
	},
	onSuccess: function() {
		console.log('Prica poslata na server');
	}

};

export default formShort;

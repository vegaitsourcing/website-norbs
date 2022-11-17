const tabs = {
	tabs: document.querySelectorAll('.js-tab'),
	tabTitle: document.querySelector('.js-tab-title'),
	tabActive: 'tab--active',

	init: function() {
		this.activeTab();
	},

	activeTab: function() {
		this.tabs.forEach((tab) => {
			tab?.addEventListener('click', () => {
				this.tabs.forEach((tabs) => {
					tabs.classList.remove(this.tabActive);
				});
				tab.classList.add(this.tabActive);

				const tabText = tab.textContent;
				this.tabTitle.innerHTML = tabText;

				const tag = tab.getAttribute('data-tag');
				const cards = document.querySelectorAll('.resource-card');

				if (tag === '' || tag === null) {
					cards.forEach((card) => {
						card.classList.remove('hidden');
					});
					return;
				}
				cards.forEach((card) => {
					if (card.getAttribute('data-tag') === tag) {
						card.classList.remove('hidden');
					} else {
						card.classList.add('hidden');
					}
				});
			});
		});
		document.querySelector('.js-tab')?.click();
	},
};

export default tabs;

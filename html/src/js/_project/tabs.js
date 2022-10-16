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
			});
		});
		document.querySelector('.js-tab')?.click();
	},
};

export default tabs;
